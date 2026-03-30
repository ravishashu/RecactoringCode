using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class CreateInvoiceStep : IOrderStep
{
    private readonly ILogger _logger;

    public CreateInvoiceStep(ILogger logger)
    {
        _logger = logger;
    }

    public async Task ExecuteAsync(IOrderContext context, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Creating invoice...");

        if (!context.PaymentAccepted)
            throw new InvalidOperationException("Cannot create invoice before payment is accepted.");

        await Task.Delay(100, cancellationToken);

        var finalPrice = (context.Order.UnitPrice * context.Order.Quantity) - context.Order.Discount;
        context.Order.Price = finalPrice;
        context.InvoiceNumber = $"INV-{DateTime.UtcNow:yyyyMMddHHmmss}-{context.Order.OrderId}";
        context.Notes.Add($"Invoice created: {context.InvoiceNumber}");

        _logger.LogInformation($"Invoice created successfully. Invoice Number: {context.InvoiceNumber}");
    }
}