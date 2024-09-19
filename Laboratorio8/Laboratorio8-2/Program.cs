
using System.Security.Cryptography.X509Certificates;

public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prmtIdCuenta)
    {
        this.idCuenta = prmtIdCuenta;
        System.Console.WriteLine(
            "Constructor Clase Base para cuenta {0}", prmtIdCuenta);
    }
    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine(
        "Cuenta.CalcularIntereses() efectuado para la cuenta {0}",
            this.idCuenta);
    }
    public string getIdCuenta()
    {
        return this.idCuenta;
    }

}

public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaCorriente.CalcularIntereses() efectuado para " +
            "la cuenta {0}", getIdCuenta()
            );
    }

}
public class CuentaAhorrro : Cuenta
{
    public CuentaAhorrro(string prmtIDCuenta) : base(prmtIDCuenta)
    {
    }
    public override void CalcularIntereses()
    {
        System.Console.WriteLine(
            "CuentaAhorro.CalcularIntereses() efectuado para " +
            "la cuenta{0}", getIdCuenta()
            );
    }
}



internal class Progra
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";

        Cuenta cuenta = new Cuenta(CUENTA);
        CuentaCorriente cuentaCorriente =
            new CuentaCorriente(CUENTA);
        CuentaAhorrro cuentaAhorro =
            new CuentaAhorrro(CUENTA);
        cuenta.CalcularIntereses();
        cuentaCorriente.CalcularIntereses();
        cuentaAhorro.CalcularIntereses();
    }
}