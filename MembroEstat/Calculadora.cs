using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembroEstat
{
    internal class Calculadora
    {
        public static double Pi = 3.14;
        public double teste;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        public static int tax(int r)
        {
            return tax * 0.06;
        }
    }
}
