using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class OrderProcessor : IOrderProcessor
{
    private readonly IEnumerable<IOrderStep> _steps;
    private readonly ILogger _logger;

    public OrderProcessor(IEnumerable<IOrderStep> steps, ILogger logger)
    {
        _steps = steps ?? throw new ArgumentNullException(nameof(steps));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task ProcessAsync(OrderDetails orderDetails, CancellationToken cancellationToken = default)
    {
        var context = new OrderContext(orderDetails);

        _logger.LogInformation($"Order processing started for OrderId: {orderDetails.OrderId}");

        try
        {
            foreach (var step in _steps)
            {
                await step.ExecuteAsync(context, cancellationToken);
            }

            _logger.LogInformation($"Order processing completed for OrderId: {orderDetails.OrderId}");
            _logger.LogInformation("Processing notes:");

            foreach (var note in context.Notes)
            {
                _logger.LogInformation($" - {note}");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Order processing failed for OrderId: {orderDetails.OrderId}. Error: {ex.Message}");
            throw;
        }
    }
}