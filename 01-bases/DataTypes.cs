partial class Program
{
    static void DataTypes()
    {
        int number = 42;

        // Double
        double decimalNumber = 3.1415;

        // Boolean
        bool isTrue = true;

        // Char
        char caracter = 'C';

        // String
        string text = "Hello World";

        // Usamos var si queremos que el compilador infiera el tipo
        var inferredNumber = 100;

        Console.WriteLine($"Integer: {number}");
        Console.WriteLine($"Double: {decimalNumber}");
        Console.WriteLine($"Boolean: {isTrue}");
        Console.WriteLine($"Char: {caracter}");
        Console.WriteLine($"String: {text}");
        Console.WriteLine($"Inferred Number: {inferredNumber}");
    }
}