using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IPaymentService
{
    void AcceptPayment(OrderDetails orderDetails);
}