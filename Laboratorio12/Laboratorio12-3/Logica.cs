using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio12_3
{
    internal class Logica
    {

        public double Semiperimetro(double LadoA, double LadoB, double LadoC)
        {
            return (LadoA + LadoB + LadoC)/2;
        }

        public double Area(double LadoA, double LadoB, double LadoC)
        {
            double SemiP = Semiperimetro(LadoA, LadoB, LadoC);
            return Math.Sqrt(SemiP * (SemiP - LadoA) * (SemiP - LadoB) * (SemiP - LadoC));
        }
    }
}
