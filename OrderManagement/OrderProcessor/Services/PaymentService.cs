using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class PaymentService : IPaymentService
{
    public void AcceptPayment(OrderDetails orderDetails)
    {
        Console.WriteLine("Accept Payment");
    }
}