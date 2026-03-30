using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IInvoiceService
{
    void CreateInvoice(OrderDetails orderDetails);
}