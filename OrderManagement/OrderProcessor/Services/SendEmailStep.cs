using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class SendEmailStep : IOrderStep
{
    private readonly ILogger _logger;

    public SendEmailStep(ILogger logger)
    {
        _logger = logger;
    }

    public async Task ExecuteAsync(IOrderContext context, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Sending confirmation email...");

        if (string.IsNullOrWhiteSpace(context.InvoiceNumber))
            throw new InvalidOperationException("Cannot send email before invoice is created.");

        await Task.Delay(100, cancellationToken); // simulate email sending

        context.Notes.Add($"Confirmation email sent to {context.Order.Email}");
        _logger.LogInformation($"Confirmation email sent to {context.Order.Email}");
    }
}
