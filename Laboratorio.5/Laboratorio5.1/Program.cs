
internal class PruebaVector1
{
    private int[] sueldos; //se declara un vector

    public void Cargar()
    {
        sueldos = new int[6]; //Inicializamos el vector en 6
        for (int f = 1; f <= 5; f++)
        {
            Console.Write($"Ingrese el sueldo del operador {f} : ");
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // Asignamos los sueldos al vector 5
        }
    }

    //Muestra los suelods de los operadores en el vector sueldos[f]
    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los aprerarios \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("[" + sueldos[f] + "]");
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}