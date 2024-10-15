using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {

        private double LA, LB, LC;
        private Logica logica = new Logica();
        public Form1()
        {
            InitializeComponent();
        }

        private void LadoB_TextChanged(object sender, EventArgs e)
        {
            LB = Double.Parse(LadoB.Text);
        }

        private void LadoC_TextChanged(object sender, EventArgs e)
        {
            LC = Double.Parse(LadoC.Text);
        }

        private void Semiperimetro_Click(object sender, EventArgs e)
        {
            string result1 = logica.Semiperimetro(LA, LB, LC).ToString();
            SemiperimetroResultado.Text = result1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Area_Click(object sender, EventArgs e)
        {
            string result = logica.Area(LA, LB, LC).ToString();
            AreaResultado.Text = result;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            SemiperimetroResultado.Text = "";
            AreaResultado.Text = "";
        }

        private void SemiperimetroResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AreaResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LadoA_TextChanged(object sender, EventArgs e)
        {
            LA = Double.Parse(LadoA.Text);
        }
    }
}
