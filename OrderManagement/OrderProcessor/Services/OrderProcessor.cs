using OrderProcessor.Interfaces;
using OrderProcessor.Models;

namespace OrderProcessor.Services;

public class OrderProcessor
{
    private readonly IEnumerable<IOrderStep> _steps;

    public OrderProcessor(IEnumerable<IOrderStep> steps)
    {
        _steps = steps;
    }

    public void ProcessOrder(OrderDetails orderDetails)
    {
        Console.WriteLine("Process Order Started");

        foreach (var step in _steps)
        {
            step.Execute(orderDetails);
        }

        Console.WriteLine("Process Order Completed");
    }
}