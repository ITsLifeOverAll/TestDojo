using System.ComponentModel.DataAnnotations;

namespace TestDojo.Mocking;

public class OrderOutput
{
    private readonly FilePrinter _printer;

    public OrderOutput(FilePrinter printer)
    {
        _printer = printer;
    }

    public bool Print(Order order)
    {
        if (! order.Printed)
        {
            order.Printed = _printer.Print(order.ToString());
            return order.Printed;
        }

        return false;
    }
}

public class FilePrinter
{
    public bool Print(string content)
    {
        try
        {
            using var sw = File.AppendText("test.txt");
            sw.WriteLine(content);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}

public class Order
{
    [Required]
    public string OrderId { get; set; } = "";
    [Required]
    public string CustomerId { get; set; } = "";
    [Required]
    public string ProductId { get; set; } = "";
    public int Quantity { get; set; }
    public bool Printed { get; set; }
    public override string ToString() => $"OrderId: {OrderId}, CustomerId: {CustomerId}";
}

