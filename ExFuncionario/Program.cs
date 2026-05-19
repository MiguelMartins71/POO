using ExFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ExFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Number of employes");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employes #{i} data");

                Console.WriteLine("Outsourced?");
                char ch= char.Parse(Console.ReadLine());
                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Hours");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value Per  Hpurs");

                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'y')
                {

                    Console.WriteLine("Despesa adicional");
                    double additionalchar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalchar));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Payments");

            foreach (Employee emp in list) {

                Console.WriteLine(emp.Name + " -$" + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}
