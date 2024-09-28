
public class Problema5 : Aleatorios
{
    
    public int[] arraySinRepetidos()
    {
        HashSet<int> hashSet = new HashSet<int>(randomArr());

        int[] ArrSinDuplicados = new int[hashSet.Count];

        hashSet.CopyTo(ArrSinDuplicados);

        return ArrSinDuplicados;
    }

}
