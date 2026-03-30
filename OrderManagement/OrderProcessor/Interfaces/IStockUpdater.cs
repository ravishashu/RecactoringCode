using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IStockUpdater
{
    void UpdateStock(OrderDetails orderDetails);
}