using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class EmailService : IEmailService
{
    public void SendEmail(OrderDetails orderDetails)
    {
        Console.WriteLine("Send Email");
    }
}