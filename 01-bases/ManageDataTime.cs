partial class Program
{
    static void ShowTime()
    {
        // Fecha completa
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime noeWeekAgo = DateTime.Now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 02, 26);
        DayOfWeek weekDay = now.DayOfWeek;

        Console.WriteLine($"Fecha y hora actual {now}");
        Console.WriteLine($"Fecha y hora {today}");
        Console.WriteLine($"Fecha y hora {customDate}");
        Console.WriteLine($"Fecha y hora {noeWeekAgo}");
        Console.WriteLine($"Fecha y hora {weekDay}");
        
    }
}