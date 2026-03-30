using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class StockChecker : IStockChecker
{
    public void CheckStock(OrderDetails orderDetails)
    {
        Console.WriteLine("Check Stock");
    }
}