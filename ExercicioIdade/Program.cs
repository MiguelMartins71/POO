using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa");
            a.nome = Console.ReadLine();
            a.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa");
            b.nome = Console.ReadLine();
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade)
            {

                Console.WriteLine("Pessoa mais velha: {0}",a.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}",b.nome);
            }

        }
    }
}
