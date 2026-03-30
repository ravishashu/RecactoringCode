using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class UpdateStockStep : IOrderStep
{
    private readonly ILogger _logger;

    public UpdateStockStep(ILogger logger)
    {
        _logger = logger;
    }

    public async Task ExecuteAsync(IOrderContext context, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Updating stock...");

        if (!context.PaymentAccepted)
            throw new InvalidOperationException("Cannot update stock before payment is accepted.");

        await Task.Delay(150, cancellationToken); // simulate DB/update work

        context.Notes.Add("Stock updated.");
        _logger.LogInformation("Stock updated successfully.");
    }
}