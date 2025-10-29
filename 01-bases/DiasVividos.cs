partial class Program
{
    static void DaysOfLive()
    {
        DateTime birthday = new DateTime(2006, 2, 26);
        TimeSpan diference = DateTime.Now - birthday;
        
        Console.WriteLine($"Has vivido  {diference.Days} dias amor");
    }
}