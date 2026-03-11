using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml;
namespace MedidasTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
         
            Console.WriteLine("Entre a largura e altura do retângulo");
            Console.Write("Altura");
            x.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Largura");
            x.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = "+x.Area());
            Console.WriteLine("Perimetro ="+x.Perimetro());
            Console.WriteLine("DIAGONAL = "+x.Diagonal());
            


        }
    }
}
