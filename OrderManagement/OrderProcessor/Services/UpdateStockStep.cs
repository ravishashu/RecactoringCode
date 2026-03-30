using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class UpdateStockStep : IOrderStep
{
    public void Execute(OrderDetails orderDetails)
    {
        Console.WriteLine("Update Stock");
    }
}