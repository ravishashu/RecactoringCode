using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class CreateInvoiceStep : IOrderStep
{
    public void Execute(OrderDetails orderDetails)
    {
        Console.WriteLine("Create Invoice");

        var finalPrice = (orderDetails.UnitPrice * orderDetails.Quantity) - orderDetails.Discount;
        Console.WriteLine($"Invoice created for OrderId: {orderDetails.OrderId}, Amount: {finalPrice:C}");
    }
}