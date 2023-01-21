using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    class Program
    {
        static void Main(string[] args)
        {

            Abstract_Factory orderSystem;

            Console.WriteLine("\tPizza Menu");
            Console.WriteLine("1- Meat Pizza");
            Console.WriteLine("2- Veggie Pizza");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    orderSystem = Abstract_Factory.GetPizza(PizzaType.Meat_Pizza);
                    orderSystem.CreatePizza();
                    break;

                case 2:
                    orderSystem = Abstract_Factory.GetPizza(PizzaType.Non_Meat_Pizza);
                    orderSystem.CreatePizza();
                    break;
            }

            Console.WriteLine("\n\n\t\tThank you for choosing us");
            Console.Write("\n\tHere is your Order..! My great teacher \"Dara\"");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(700);
                Console.Write(".");

            }
        }
    }
}