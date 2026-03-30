using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class CheckStockStep : IOrderStep
{
    public void Execute(OrderDetails orderDetails)
    {
        Console.WriteLine("Check Stock");

        bool isAvailable = true;

        if (!isAvailable)
            throw new InvalidOperationException("Product is out of stock.");
    }
}