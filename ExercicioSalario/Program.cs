using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http.Headers;
namespace ExercicioSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario a = new Funcionario();  
            Funcionario b = new Funcionario();
            Console.WriteLine("Dados do primeiro Funcionário");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            a.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo Funcionário");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = a.Salario + b.Salario / 2;

            Console.WriteLine("Salario medio:"+media);

        }
    }
}
