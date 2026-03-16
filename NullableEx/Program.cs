using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nullable<double> x = null;
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            Console.WriteLine();
            double teste = x ?? 1102;
            Console.WriteLine(teste);

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é nulo");

            if(y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("errado");
        }
    }
}
