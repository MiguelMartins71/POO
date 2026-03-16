using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class DadosBancarios
    {
        private int _id;
        private string _name { get; set; }
        private double _deposito {  get; set; }


        public DadosBancarios()
        {

        }

        public DadosBancarios(int numero, string name, double valor)
        {
            _id = numero;
            _name = name;   
            _deposito = valor;

        }

        public int id
        {

            get { return _id; }
            set { 
            if(value>0)
                {
                    _id = value;
                }
                else
                {
                    Console.WriteLine("Entrada inválida");
                }
                 
            }
        }

        
        public void AdicionarDeposito(int depositar)
        {
            _deposito += depositar;
        }

        public void Sacar(int saque)
        {
            _deposito -= saque;
        }

        public double ValorTotal()
        {
           return _deposito;
        }

        public override string ToString()
        {
            return "Conta, " + _id + " Titular: " + _name + "Saldo"  + ValorTotal().ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
