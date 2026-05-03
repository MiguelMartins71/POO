using Enumeracao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
        }
    }
}
