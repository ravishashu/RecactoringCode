using OrderProcessor.Models;

namespace OrderProcessor.Interfaces;

 
    public interface IOrderProcessor
    {
        void ProcessOrder(OrderDetails orderDetails);
    }
