using OrderProcessor.Interfaces;
using OrderProcessor.Models;
using OrderProcessor.Services;

Console.WriteLine("Order Start");

ILogger logger = new ConsoleLogger();

var steps = new List<IOrderStep>
{
    new ValidateOrderStep(logger),
    new CheckStockStep(logger),
    new AcceptPaymentStep(logger),
    new UpdateStockStep(logger),
    new CreateInvoiceStep(logger),
    new SendEmailStep(logger)
};

IOrderProcessor processor = new OrderProcessor.Services.OrderProcessor(steps, logger);

var order = new OrderDetails
{
    Id = 1,
    OrderId = 1001,
    ProductName = "Wireless Mouse",
    UnitPrice = 25.99m,
    Quantity = 2,
    Discount = 5.00m,
    Email = "customer@example.com",
    Phone = "9876543210",
    Address = "123 High Street, London, UK",
    PaymentDetails = "Paid via Credit Card"
};

await processor.ProcessAsync(order);

Console.WriteLine("Order End");