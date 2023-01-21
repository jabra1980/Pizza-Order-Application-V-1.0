using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public interface IBuilder
    {
        public void BuildDescription();
        public void BuildBread();
        public void BuildSize();
        public void BuildSauce();
        public void BuildCheese();
        public void BuildProtein();
        public void BuildVegetable();
        public void BuildPizzaName();



        public Pizza GetPizza();
    }
}
