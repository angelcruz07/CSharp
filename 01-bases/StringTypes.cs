partial class Program
{
    static void ShowStringTypes()
    {
        // 1. Tipos Básicos de Cadena y Carácter

        // Declaración de una cadena de texto (inmutable, referencia).
        string text = "Hello, World!";
        string name = "Angel";

        // Declaración de un carácter individual (valor, se usa comillas simples).
        char character = 'A';

        // 2. Cadenas con Funcionalidades Especiales

        // Cadena interpolada: permite incrustar variables o expresiones dentro de una cadena
        // prefijándola con el símbolo '$'.
        string interpolateString = $"Hola {name}";

        // Cadena vacía: una referencia válida a un objeto string cuya longitud es cero.
        string emptyString = string.Empty;

        // Cadena literal textual (verbatim string): ignora secuencias de escape (como \n, \t)
        // y permite que la cadena abarque varias líneas sin usar \n. Se usa el símbolo '@'.
        string multiLineString = @"This is a multi-line
        string that spans
        multiple lines.";

        // 3. Métodos y Propiedades Comunes de la Clase string

        // Métodos de manipulación (no modifican la cadena original, devuelven una nueva):
        string upperName = name.ToUpper();   // Devuelve "ANGEL"
        string lowerName = name.ToLower();   // Devuelve "angel"
        
        // Propiedad para obtener la longitud de la cadena:
        int length = name.Length;            // Devuelve 5

        // Método de consulta:
        bool containsSubstring = name.Contains("gel"); // Devuelve true

        // 4. Salida a la Consola
        
        Console.WriteLine(interpolateString);
        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Character: {character}");
        Console.WriteLine($"Empty String: '{emptyString}'");
        Console.WriteLine("Multi-line String:");
        Console.WriteLine(multiLineString);
        
        // Ejemplo de salida de los resultados de los métodos/propiedades
        Console.WriteLine($"Name in Upper Case: {upperName}");
        Console.WriteLine($"Name Length: {length}");
        Console.WriteLine($"Contains 'gel': {containsSubstring}");
    }
}