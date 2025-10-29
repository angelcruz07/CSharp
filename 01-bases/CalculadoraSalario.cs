partial class Program
{
    static void SalaryCalculator()
    {
        Console.WriteLine("Ingrese su nombre: ");
        string name = Console.ReadLine();

        Console.WriteLine("Ingrese las hora trabajadas");
        double workedHours = double.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Ingrese salario por hora");
        double salary = double.Parse(Console.ReadLine());

        double totalSalary = workedHours * salary;
        

        Console.WriteLine($"El salario de {name} por {workedHours} houras es de {totalSalary}."); 
    }
}