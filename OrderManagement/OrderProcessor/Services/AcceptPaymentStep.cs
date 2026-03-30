using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class AcceptPaymentStep : IOrderStep
{
    public void Execute(OrderDetails orderDetails)
    {
        Console.WriteLine("Accept Payment");

        if (string.IsNullOrWhiteSpace(orderDetails.PaymentDetails))
            throw new InvalidOperationException("Payment details are missing.");
    }
}