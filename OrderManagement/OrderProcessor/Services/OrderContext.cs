using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class OrderContext : IOrderContext
{
    public OrderContext(OrderDetails order)
    {
        Order = order ?? throw new ArgumentNullException(nameof(order));
    }

    public OrderDetails Order { get; }
    public bool IsValid { get; set; }
    public bool StockAvailable { get; set; }
    public bool PaymentAccepted { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty;
    public List<string> Notes { get; } = new();
}