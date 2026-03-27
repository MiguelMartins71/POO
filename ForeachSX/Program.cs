using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Miguel", "Teste" };

            foreach (string s in vect)
            {
                Console.WriteLine(s);

            }

            for (int i = 0; i < vect.Length; i++)
            {

                Console.WriteLine(vect[i]);
            }
        }
    }
}
