partial class Program
{
    static void ListDiccionary()
    {
        
        //Lista
        List<string> names = new List<string>{"Ana","Carlos", "Maria","Juan"};
        names.Add("Angel");

        Console.WriteLine($"Total de nombres: {names.Count}");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Juan");
        bool isPresent = names.Contains("Ana");
        Console.WriteLine($"Ana esta en la lista: {isPresent}");

        // Diccionario
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Ana" },
            { 2, "Maria" },
            { 3, "Juan" },
        };

        Console.WriteLine($"El estudiante con ID 1 es: {students[1]}");
        
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }
    }
}