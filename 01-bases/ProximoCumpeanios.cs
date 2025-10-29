using System.Globalization;

partial class Program
{
    static void DaysUntilNextYear()
    {
        Console.WriteLine("Ingrese su fecha de nacimiento: (dd/mm/yyyy): ");
        string fecha = Console.ReadLine()!;
        
        DateTime birthDate = DateTime.ParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        
        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthdate = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);

        if (nextBirthdate < currentDate)
        {
            nextBirthdate = nextBirthdate.AddYears(1);
        }
        
        int dayRemaining = (nextBirthdate - currentDate).Days;
        
        Console.WriteLine($"Faltan {dayRemaining} dias para tu siguiente cumpleanios");
    }
}