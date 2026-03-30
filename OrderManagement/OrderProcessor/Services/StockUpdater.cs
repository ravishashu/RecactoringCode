using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class StockUpdater : IStockUpdater
{
    public void UpdateStock(OrderDetails orderDetails)
    {
        Console.WriteLine("Update Stock");
    }
}