partial class Program
{
    static void Operators()
    {
        int number = 15;

        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number % 10 == 0;

        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El numero {number} es par y mayo que 10");
        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"El numero {number} es impar y es mayor que 10");
        }
        else
        {
            Console.WriteLine($"El numero {number} no cumple con las condiciones");
        }

        int age = 19;
        string categoria = age > 18 ? "Adulto" : "Menor";

        Console.WriteLine(categoria);
    }
}