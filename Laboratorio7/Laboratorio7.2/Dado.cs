﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7._2
{
     class Dado
    {
        private int valor;
        private static Random aleatorio;

        public void Tirar()
        {
            valor = aleatorio.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es:" + valor);
        }

        public int RetornarValor()
        {
            return valor;
        }
       
    }
}