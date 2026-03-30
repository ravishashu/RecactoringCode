using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IOrderValidator
{
    void Validate(OrderDetails orderDetails);
}