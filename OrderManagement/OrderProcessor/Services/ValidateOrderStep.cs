using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class ValidateOrderStep : IOrderStep
{
    private readonly ILogger _logger;

    public ValidateOrderStep(ILogger logger)
    {
        _logger = logger;
    }

    public Task ExecuteAsync(IOrderContext context, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Validating order...");

        var order = context.Order;

        if (string.IsNullOrWhiteSpace(order.ProductName))
            throw new ArgumentException("Product name is required.");

        if (order.Quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");

        if (order.UnitPrice <= 0)
            throw new ArgumentException("Unit price must be greater than zero.");

        if (string.IsNullOrWhiteSpace(order.Email))
            throw new ArgumentException("Customer email is required.");

        context.IsValid = true;
        context.Notes.Add("Order validation passed.");

        _logger.LogInformation("Order validation completed.");
        return Task.CompletedTask;
    }
}