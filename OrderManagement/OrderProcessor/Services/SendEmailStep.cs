using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class SendEmailStep : IOrderStep
{
    public void Execute(OrderDetails orderDetails)
    {
        Console.WriteLine("Send Email");
        Console.WriteLine($"Email sent to {orderDetails.Email}");
    }
}