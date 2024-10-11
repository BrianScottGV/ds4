using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio12
{
    internal class Logica
    {

        private Form1 Form = new Form1();

        public double DistanciaRecorrida()
        {
            return Form.VelocidadMV * Form.TmpMovilUsado;
        }

    }
}
