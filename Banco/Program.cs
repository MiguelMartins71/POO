using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char opcao;
         
            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial? s/n");
            opcao = char.Parse
                (Console.ReadLine());
            Console.WriteLine("Entre o valor do depósito incial");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da Conta/n Conta {0}, Titular: {1}, Saldo: {2}",numero,nome,valor);

            DadosBancarios banco = new DadosBancarios(numero, nome, valor);

            if(opcao == 's')
            {

                Console.WriteLine("Entre com um valor para deposito");
                int novodeposito = int.Parse(Console.ReadLine());
                banco.AdicionarDeposito(novodeposito);



            }

            Console.WriteLine(banco);

            Console.WriteLine("Entre com um valor para saque: ");
            int novosaque = int.Parse(Console.ReadLine());
            banco.Sacar(novosaque);

            Console.WriteLine("Dados atualizados: "+banco);

        }
    }
}
