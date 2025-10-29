partial class Program
{
    static void ShowNumericTypes()
    {
        // Entero de 32 bits
        int integerNumber = 42; 

        // Decimales de 64 bits
        double doubleNumber = 3.1416;

        // Decimales de 32 bits 
        // - Presición
        // - Menos memoria utlizasa
        float floatNumber = 2.61f;

        // Numeros bastante grandes
        long longNumber = 100_922_100L;

        // Decimal 
        // Mayor presición
        // Programas financieros
        decimal decimalNumber = 89.29m;

        Console.WriteLine($"Enteros: {integerNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"Float: {floatNumber}");
        Console.WriteLine($"Long: {longNumber}");
        Console.WriteLine($"Decimal: {decimalNumber}");
    }
}