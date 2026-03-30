using OrderProcessor;
using OrderProcessor.Models;
using OrderProcessor.Services;

Console.WriteLine("Order Start");

var orderProcessor = new OrderProcessor.Services.OrderProcessor(
    new OrderValidator(),
    new StockChecker(),
    new PaymentService(),
    new StockUpdater(),
    new InvoiceService(),
    new EmailService());

var order = new OrderDetails
{
    Id = 1,
    OrderId = 1001,
    ProductName = "Laptop",
    UnitPrice = 1000m,
    Quantity = 1,
    Discount = 50m,
    Price = 950m,
    Email = "customer@example.com",
    Phone = "9876543210",
    Address = "10 Downing Street, London",
    PaymentDetails = "Credit Card"
};

orderProcessor.ProcessOrder(order);

Console.WriteLine("Order End");