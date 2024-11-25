using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio15._4
{
    public partial class Suma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Aquí va el código para la carga de la página (si es necesario)
        }

        // Manejador para el evento de clic del botón
        protected void btnSumar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los cuadros de texto
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            // Realizar la suma
            double resultado = numero1 + numero2;

            // Mostrar el resultado en el label
            lblResultado.Text = "El resultado es: " + resultado.ToString();
        }
    }
}
