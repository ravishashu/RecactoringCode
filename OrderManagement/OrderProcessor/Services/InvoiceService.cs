using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class InvoiceService : IInvoiceService
{
    public void CreateInvoice(OrderDetails orderDetails)
    {
        Console.WriteLine("Create Invoice");
    }
}