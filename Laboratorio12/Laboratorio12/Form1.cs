using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12
{
    public partial class Form1 : Form
    {

        public double VelocidadMV { get; set; }
        public double TmpMovilUsado { get; set; }

        private Logica logica = new Logica();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {
        }

        private void VelocidadMovil_TextChanged(object sender, EventArgs e)
        {
             VelocidadMV = Double.Parse(VelocidadMovil.Text);
        }

        private void TextBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = logica.DistanciaRecorrida(VelocidadMV, TmpMovilUsado);
            TextBoxResultado.Text = resultado.ToString();
        }

        private void TiempoMovilUsado_TextChanged(object sender, EventArgs e)
        {
            TmpMovilUsado = Double.Parse(TiempoMovilUsado.Text);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (TextBoxResultado.Text != "")
            {
                TextBoxResultado.Text = "";
            }
        }

        private void BtnCompilacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
