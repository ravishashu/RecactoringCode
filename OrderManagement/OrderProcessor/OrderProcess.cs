namespace OrderProcessor;

public class OrderProcess
{

    public void ProcessOrder(OrderDetails orderDetails)
    {
        try
        {
            Console.WriteLine("Process Order");
            ValidateOrder(orderDetails);
            CheckSock(orderDetails);
            AcceptPayment(orderDetails);
            UpdateStock(orderDetails);
            CreateInvoice(orderDetails);
            ShipOrder(orderDetails);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }


    }

   

    public void ValidateOrder(OrderDetails orderDetails)
    {
        Console.WriteLine("Validate Order");
    }

    public void CheckSock(OrderDetails orderDetails)
    {
        Console.WriteLine("Check Stock");
    }

    public void AcceptPayment(OrderDetails orderDetails)
    {
        Console.WriteLine("Accept Payment");
    }

    public void UpdateStock(OrderDetails orderDetails)
    {
        Console.WriteLine("Update Stock");
    }

    public void CreateInvoice(OrderDetails orderDetails)
    {

        Console.WriteLine("Create Invoice");
        SendEmail(orderDetails);
    }

    private void ShipOrder(OrderDetails orderDetails)
    {
        Console.WriteLine("Ship Order");
        SendEmail(orderDetails);
    }

    public void SendEmail(OrderDetails orderDetails)
    {
        Console.WriteLine("Send Email");
    }
}