
internal class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.WriteLine($"Numero random generado entre 2 numeros: {aleatorios.random2Numeros()}\n" +
            $"Arreglo con numeros generados entre 2 numeros: {string.Join(",", aleatorios.randomArr())}");

        //Problema 5
        Problema5 problema5 = new Problema5();

        Console.WriteLine($"\n\n\n\nArray sin repetidos: {string.Join(",",problema5.arraySinRepetidos())}");
    }
}