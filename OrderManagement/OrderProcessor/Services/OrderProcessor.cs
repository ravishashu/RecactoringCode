using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class OrderProcessor(
    IOrderValidator orderValidator,
    IStockChecker stockChecker,
    IPaymentService paymentService,
    IStockUpdater stockUpdater,
    IInvoiceService invoiceService,
    IEmailService emailService)
    : IOrderProcessor
{
    
    public void ProcessOrder(OrderDetails orderDetails)
    {
        Console.WriteLine("Process Order");

        orderValidator.Validate(orderDetails);
        stockChecker.CheckStock(orderDetails);
        paymentService.AcceptPayment(orderDetails);
        stockUpdater.UpdateStock(orderDetails);
        invoiceService.CreateInvoice(orderDetails);
        emailService.SendEmail(orderDetails);
        
    }
}