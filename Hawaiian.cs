using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Hawaiian : IBuilder
    {
        Pizza pizza;

        public Hawaiian()
        {
            pizza = new Pizza();
        }

        public void BuildPizzaName()
        {
            pizza.SetPizzaName(PizzaType.Hawaiian);
        }

        public void BuildDescription()
        {
            pizza.SetDescription(PizzaType.Hawaiian);
        }

        public void BuildBread()
        {
            pizza.SetBread(PizzaType.Hawaiian);
        }

        public void BuildSize()
        {
            pizza.SetSizeInch(PizzaType.Hawaiian);
        }

        public void BuildSauce()
        {
            pizza.SetSauce(PizzaType.Hawaiian);
        }

        public void BuildCheese()
        {
            pizza.SetCheese(PizzaType.Hawaiian);
        }

        public void BuildProtein()
        {
            pizza.SetProtein(PizzaType.Hawaiian);
        }

        public void BuildVegetable()
        {
            pizza.SetVegetable(PizzaType.Hawaiian);
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
