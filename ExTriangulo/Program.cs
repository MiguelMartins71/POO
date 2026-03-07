using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ExTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo Y = new Triangulo();
            Console.WriteLine("Entre com as medidados do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidados do triângulo Y:");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (Y.A + Y.B + Y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - Y.A) * (p - Y.B) * (p - Y.C));

            Console.WriteLine("Área de X= " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de X= " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {

                Console.WriteLine("Maior area X");
            }
            else
            {
                Console.WriteLine("Maior area Y:");
            }
            
            
        }
    }
}
