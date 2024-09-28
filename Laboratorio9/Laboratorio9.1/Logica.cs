
using System.Reflection.Metadata;

public class Logica
{
    // Variables
    private double PrecioProducto;
    private string FormaDePago;
    private string NumeroDeCuenta;

    // Constructor
    public Logica(double PrecioProducto, string FormaDePago, string NumeroDeCuenta)
    {
        this.PrecioProducto = PrecioProducto;
        this.FormaDePago = FormaDePago;
        this.NumeroDeCuenta = NumeroDeCuenta;
    }

    // Getters
    public double getPrecioProducto()
    {
        return PrecioProducto;
    }

    public string getFormaDePago()
    {
        return FormaDePago;
    }

    public string getNumeroDeCuenta()
    {
        return NumeroDeCuenta;
    }

}

