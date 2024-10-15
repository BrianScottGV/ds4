using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_2
{
    public partial class Form1 : Form
    {

        public double NotaNum1, NotaNum2, NotaNum3;

        private Logica logica = new Logica();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NotaN2_TextChanged(object sender, EventArgs e)
        {
            NotaNum2 = Double.Parse(NotaN2.Text);
        }

        private void NotaN3_TextChanged(object sender, EventArgs e)
        {
            NotaNum3 = Double.Parse(NotaN3.Text);
        }

        private void Promedio_Click(object sender, EventArgs e)
        {
            string resultado = logica.PromedioNotas(NotaNum1,NotaNum2,NotaNum3).ToString();
            NotaPromedio.Text = resultado;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            NotaPromedio.Text = "";
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        { 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NotaNum1 = Double.Parse(NotaN1.Text);
        }
    }
}
