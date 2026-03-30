using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

public interface IOrderContext
{
    OrderDetails Order { get; }
    bool IsValid { get; set; }
    bool StockAvailable { get; set; }
    bool PaymentAccepted { get; set; }
    string InvoiceNumber { get; set; }
    List<string> Notes { get; }
}