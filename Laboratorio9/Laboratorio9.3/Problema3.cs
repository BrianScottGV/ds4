
public class Probleama3
{

    private double Lado1, Lado2, Lado3;

    public Probleama3(double Lado1, double Lado2, double Lado3)
    {
        this.Lado1 = Lado1;
        this.Lado2 = Lado2;
        this.Lado3 = Lado3;
    }

    public double getLado1()
    {
        return this.Lado1;
    }
    public double getLado2()
    {
        return this.Lado2;
    }
    public double getLado3()
    {
        return this.Lado3;
    }

    public string tipoTriangulo()
    {
        if (Lado1 != Lado2 && Lado2 != Lado3 && Lado3 != Lado1)
        {
            return "Triangulo Escaleno";
        }
        else if (Lado1 == Lado2 && Lado2 == Lado3 && Lado3 == Lado1)
        {
            return "Triangulo Equilatero";
        }
        else
        {
            return "Triangulo Isosceles";
        }
    }
}
