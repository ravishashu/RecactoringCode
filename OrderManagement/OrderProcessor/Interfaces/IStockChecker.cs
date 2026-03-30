using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IStockChecker
{
    void CheckStock(OrderDetails orderDetails);
}