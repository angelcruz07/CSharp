partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [5, 9, 10];
        double[] prices = [256.5, 69.8, 70.5];

        Console.WriteLine("----- Menu ------");
        Console.WriteLine("1. Comprar producto");
        Console.WriteLine("2. Salir");

        Console.WriteLine("\nSeleccione una opción");
        int option = int.Parse(Console.ReadLine()!);

        if (option == 1)
        {
            Console.WriteLine("Inventario de productos:");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]}, Stock: {stock[i]}, Price:  ${prices[i]}");
            }

            System.Console.WriteLine("\nIngrese el producto que desea comprar:");
            string searchedProduct = Console.ReadLine();

            System.Console.WriteLine("Ingrese la cantidad que desea comprar: ");
            int quantity = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i]) 
                    {
                        double total = quantity * prices[i];
                        stock[i] -= quantity;
                        
                        Console.WriteLine( $"Compra exitosa: {total}");
                        Console.WriteLine($"Stock restante para el producto: {searchedProduct} es: {stock[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"No hay suficiente stock");
                    }
                }
            }
        }
        else if (option == 2)
        {
            Console.WriteLine("Gracias por su visita");
        }
        else
        {
            Console.WriteLine("Esta Opción no existe");
        }
    }
}