using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class AcceptPaymentStep : IOrderStep
{
    private readonly ILogger _logger;

    public AcceptPaymentStep(ILogger logger)
    {
        _logger = logger;
    }

    public async Task ExecuteAsync(IOrderContext context, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Accepting payment...");

        if (!context.IsValid)
            throw new InvalidOperationException("Cannot accept payment for an invalid order.");

        if (!context.StockAvailable)
            throw new InvalidOperationException("Cannot accept payment when stock is unavailable.");

        if (string.IsNullOrWhiteSpace(context.Order.PaymentDetails))
            throw new InvalidOperationException("Payment details are missing.");

        await Task.Delay(200, cancellationToken); // simulate payment gateway call

        context.PaymentAccepted = true;
        context.Notes.Add("Payment accepted.");

        _logger.LogInformation("Payment accepted.");
    }
}