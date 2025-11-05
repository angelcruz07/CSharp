partial class Program
{
    static void HandleNullable()
    {
        string firstName = "Angel";
        string lastName = "Cruz";

        Console.WriteLine(firstName);

        if (lastName != null)
        {
            Console.WriteLine(lastName);
        }
        else
        {
            Console.WriteLine($"Apellido no especicado");
        }

        Console.WriteLine($"Apellido: {lastName ?? "Apellido no esp"}");
        Console.Write("Sigue ejecutando");
    }
}