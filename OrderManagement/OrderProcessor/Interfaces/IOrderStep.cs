using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IOrderStep
{
    void Execute(OrderDetails orderDetails);
}