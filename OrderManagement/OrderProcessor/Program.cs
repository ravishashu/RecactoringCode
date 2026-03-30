using OrderProcessor.Interfaces;
using OrderProcessor.Models;
using OrderProcessor.Services;

Console.WriteLine("Order Start");

var orderDetails = new OrderDetails
{
    Id = 1,
    OrderId = 1001,
    ProductName = "Wireless Mouse",
    UnitPrice = 25.99m,
    Quantity = 2,
    Discount = 5.00m,
    Price = 46.98m,
    Email = "customer@example.com",
    Phone = "9876543210",
    Address = "123 High Street, London, UK",
    PaymentDetails = "Paid via Credit Card"
};

var steps = new List<IOrderStep>
{
    new ValidateOrderStep(),
    new CheckStockStep(),
    new AcceptPaymentStep(),
    new UpdateStockStep(),
    new CreateInvoiceStep(),
    new SendEmailStep()
};

var orderProcessor = new OrderProcessor.Services.OrderProcessor(steps);

try
{
    orderProcessor.ProcessOrder(orderDetails);
}
catch (Exception ex)
{
    Console.WriteLine($"Error processing order: {ex.Message}");
}

Console.WriteLine("Order End");