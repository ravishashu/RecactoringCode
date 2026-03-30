using OrderProcessor;

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

var orderProcess = new OrderProcess();
orderProcess.ProcessOrder(orderDetails);
Console.WriteLine("Order End");