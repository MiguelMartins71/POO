using Heranca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Account acc = new Account(1001,"Alex",0.0);
            BusinessAccount bacc = new BusinessAccount(100, "m", 0.0, 200.0);

            //Upcasting
            Account acc1 = bacc;

            Account acc2 = new BusinessAccount(1000, "m",0.0,0.0);

            Account acc3 = new SavingsAccount(100, "n", 10, 10);
            //Downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);


           if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");


            }

            */

            Account acc1 = new Account(1, "M", 500.00);
            Account acc2 = new SavingsAccount(2, "ana", 500.00,0.0);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


        }
    }
}
