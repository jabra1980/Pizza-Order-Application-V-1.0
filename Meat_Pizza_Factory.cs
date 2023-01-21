using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Meat_Pizza_Factory : Abstract_Factory
    {

        public override void CreatePizza()
        {
            
            IBuilder hBuilder = new Hawaiian();
            Chief hChief = new Chief(hBuilder);

            
            IBuilder mBuilder = new MeatZZa();
            Chief mChief = new Chief(mBuilder);

            Console.WriteLine("\tMeat Pizza Menu");
            Console.WriteLine("1- Hawaiian");
            Console.WriteLine("2- MeatZZa");
            int option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                  case 1:
                    hChief.ConstructPizza();
                    hChief.FinalPizza().Display();
                    break;

                  case 2:
                    mChief.ConstructPizza();
                    mChief.FinalPizza().Display();
                    break;
            }



        }
    }
}
