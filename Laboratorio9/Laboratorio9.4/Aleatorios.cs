
public class Aleatorios
{
    private Random r = new Random();

    public int random2Numeros()
    {
        int Num1 = r.Next(1,500), Num2 = r.Next(501, 1000);
        return r.Next(Num1, Num2);
    }

    public int[] randomArr()
    {
        int Num1 = r.Next(1, 500), Num2 = r.Next(501, 1000);
        int[] Arr;
        int TempMayor = Math.Max(Num1,Num2), TempMenor = Math.Min(Num1,Num2);

        Arr = new int[TempMayor - TempMenor + 1];
        
        for ( int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = TempMenor + i;
        }
        return Arr;
    }
}
