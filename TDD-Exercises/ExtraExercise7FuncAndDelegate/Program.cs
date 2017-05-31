using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise7FuncAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order()
            {
                Name = "Widget A",
                Price = 3.14m,
                Quantity = 100,
                Paid = false
            };

            List<Action<Order>> listOfActions = new List<Action<Order>>();

            listOfActions.Add((o) => o.Name += " -In Stock");
            listOfActions.Add((o) => o.Price = o.Price * 1.25M);
            listOfActions.Add((o) => o.Quantity = o.Quantity - 10);
            listOfActions.Add((o) => o.Name += "-Paid");
            listOfActions.Add((o) => o.Paid = true);

            ProcessOrder(order, listOfActions);
            Console.WriteLine(order.Name);
            Console.WriteLine(order.Price);
            Console.WriteLine(order.Quantity);

            Console.ReadKey();
        }

        static void ProcessOrder(Order theOrder, List<Action<Order>> actions)
        {
            actions.ForEach(a => a(theOrder));
        }

    }
}
