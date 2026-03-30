using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class OrderValidator : IOrderValidator
{
    public void Validate(OrderDetails orderDetails)
    {
        Console.WriteLine("Validate Order");

        if (orderDetails == null)
            throw new ArgumentNullException(nameof(orderDetails));

        if (string.IsNullOrWhiteSpace(orderDetails.ProductName))
            throw new ArgumentException("Product name is required.");

        if (orderDetails.Quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");

        if (orderDetails.UnitPrice <= 0)
            throw new ArgumentException("Unit price must be greater than zero.");
    }
}