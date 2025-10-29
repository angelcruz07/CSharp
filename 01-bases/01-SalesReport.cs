partial class Program
{
    static void ShowSalesReport()
    {
        string product = "Laptop";
        int quantitySold = 150;
        decimal pricePerUnit = 999.99m;
        decimal totalSales = quantitySold * pricePerUnit;

        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quantity Sold: {quantitySold}");
        Console.WriteLine($"Price per Unit: {pricePerUnit:C}");
        Console.WriteLine($"Total Sales: {totalSales:C}");
    }
}