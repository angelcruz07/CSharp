partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];

        numbers[0] = 1;
        numbers[1] = 2;
        
        
        // Directa
        int[] numbersArray = [1, 2, 25, 5];
        // Indices
        Console.WriteLine($"Primer elemento {numbersArray[0]}");
        Console.WriteLine($"Segundo elemento {numbersArray[1]}");
        Console.WriteLine($"Tercer elemento {numbersArray[2]}");
        Console.WriteLine($"Total de elementos {numbersArray.Length}");
        
        // Desde el final de arrelgos
        Console.WriteLine($"Ultimo elemento {numbersArray[^1]}");
        Console.WriteLine($"Penultimo elemento {numbersArray[^2]}");
        
        // Rangos para obtener subarreglos
        int[] firstThree = numbersArray[..3];
        int[] fromIndexTwo = numbersArray[2..];

        foreach (var number in fromIndexTwo)
        {
            Console.WriteLine(number);
        }

        foreach (var number in firstThree)
        {
            Console.WriteLine(number);
        }
    }
}