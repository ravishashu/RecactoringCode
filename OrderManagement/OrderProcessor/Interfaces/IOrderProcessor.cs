using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IOrderProcessor
{
    Task ProcessAsync(OrderDetails orderDetails, CancellationToken cancellationToken = default);
}