using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class MeatZZa : IBuilder
    {
        Pizza pizza;

        public MeatZZa()
        {
            pizza = new Pizza();
        }

        public void BuildPizzaName()
        {
            pizza.SetPizzaName(PizzaType.MeatZZa);
        }

        public void BuildDescription()
        {
            pizza.SetDescription(PizzaType.MeatZZa);
        }

        public void BuildBread()
        {
            pizza.SetBread(PizzaType.MeatZZa);
        }

        public void BuildSize()
        {
            pizza.SetSizeInch(PizzaType.MeatZZa);
        }

        public void BuildSauce()
        {
            pizza.SetSauce(PizzaType.MeatZZa);
        }

        public void BuildCheese()
        {
            pizza.SetCheese(PizzaType.MeatZZa);
        }

        public void BuildProtein()
        {
            pizza.SetProtein(PizzaType.MeatZZa);
        }

        public void BuildVegetable()
        {
            pizza.SetVegetable(PizzaType.MeatZZa);
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
