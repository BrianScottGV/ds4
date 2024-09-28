
internal class Program
{
    static void Main(string[] args)
    {
        double Lado1 = .0, Lado2 = .0, Lado3 = .0;
        try
        {
            Console.Write("Introduzca el valor del primer lado del triangulo: ");
            Lado1 = Double.Parse(Console.ReadLine());

            Console.Write("Introduzca el valor del primer lado del triangulo: ");
            Lado2 = Double.Parse(Console.ReadLine());

            Console.Write("Introduzca el valor del primer lado del triangulo: ");
            Lado3 = Double.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        Probleama3 p = new Probleama3(Lado1, Lado2, Lado3);

        Console.WriteLine("El triangulo es: " + p.tipoTriangulo());
    }
}
