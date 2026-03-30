using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IEmailService
{
    void SendEmail(OrderDetails orderDetails);
}