
using System.Linq.Expressions;

internal class Program
{
    static void Main(string[] args)
    {
        // Main variables
        double PrecioProducto = .0;
        string FormaDePago = "";
        string NumeroDeCuenta = "";

        // Main logic
        try
        {
            Console.Write("Ingrese el precio del producto: ");
            PrecioProducto = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese la forma de pago (Efectivo o Tarjeta): ");
            FormaDePago = Console.ReadLine();

            if (string.Equals(FormaDePago, "tarjeta", StringComparison.OrdinalIgnoreCase))
            {
                bool valido = false;

                while (!valido)
                {
                    Console.Write("Ingrese el numero de cuenta: ");
                    NumeroDeCuenta = Console.ReadLine();
                    if (NumeroDeCuenta.Length == 16)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("El numero de cuenta debe tener 16 digitos.");
                    }
                }
                
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Logica logica = new Logica(PrecioProducto, FormaDePago, NumeroDeCuenta);

        Console.WriteLine($"Precio del Producto: ${logica.getPrecioProducto()}.\n " +
            $"Forma de pago: {logica.getFormaDePago()}\n " +
            $"Numero de cuenta: {logica.getNumeroDeCuenta()}");
    } 
    
}
