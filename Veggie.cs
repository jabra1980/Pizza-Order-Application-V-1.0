using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Veggie : IBuilder
    {
        Pizza pizza;

        public Veggie()
        {
            pizza = new Pizza();
        }

        public void BuildPizzaName()
        {
            pizza.SetPizzaName(PizzaType.Veggie);
        }

        public void BuildDescription()
        {
            pizza.SetDescription(PizzaType.Veggie);
        }

        public void BuildBread()
        {
            pizza.SetBread(PizzaType.Veggie);
        }

        public void BuildSize()
        {
            pizza.SetSizeInch(PizzaType.Veggie);
        }

        public void BuildSauce()
        {
            pizza.SetSauce(PizzaType.Veggie);
        }

        public void BuildCheese()
        {
            pizza.SetCheese(PizzaType.Veggie);
        }

        public void BuildProtein()
        {
            pizza.SetProtein(PizzaType.Veggie);
        }

        public void BuildVegetable()
        {
            pizza.SetVegetable(PizzaType.Veggie);
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
