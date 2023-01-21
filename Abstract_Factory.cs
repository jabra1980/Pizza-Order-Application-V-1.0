using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public abstract class Abstract_Factory
    {
        private static Meat_Pizza_Factory meat_Pizza_Factory = new Meat_Pizza_Factory();
        private static Non_Meat_Pizza_Factory non_Meat_Pizza_Factory = new Non_Meat_Pizza_Factory();

        public static Abstract_Factory GetPizza(PizzaType pizza)
        {
            Abstract_Factory? factory = null;

            switch (pizza)
            {
                case PizzaType.Meat_Pizza:
                    factory = meat_Pizza_Factory;
                    break;

                case PizzaType.Non_Meat_Pizza:
                    factory= non_Meat_Pizza_Factory;
                    break;
            }
            return factory;
        }

        public abstract void CreatePizza();
    }
}
