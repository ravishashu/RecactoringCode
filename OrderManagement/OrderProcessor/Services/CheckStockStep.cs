using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class CheckStockStep : IOrderStep
{
    private readonly ILogger _logger;

    public CheckStockStep(ILogger logger)
    {
        _logger = logger;
    }

    public async Task ExecuteAsync(IOrderContext context, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Checking stock...");

        await Task.Delay(200, cancellationToken); // simulate I/O work

        // Dummy stock check
        var isAvailable = true;

        if (!isAvailable)
            throw new InvalidOperationException("Product is out of stock.");

        context.StockAvailable = true;
        context.Notes.Add("Stock is available.");

        _logger.LogInformation("Stock check completed.");
    }
}