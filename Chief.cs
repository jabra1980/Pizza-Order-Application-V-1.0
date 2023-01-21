using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Chief
    {
        IBuilder iBuilder;

        public Chief(IBuilder iBuilder)
        {
            this.iBuilder = iBuilder;
        }

        public void ConstructPizza()
        {
            iBuilder.BuildPizzaName();
            iBuilder.BuildBread();
            iBuilder.BuildSize();
            iBuilder.BuildSauce();
            iBuilder.BuildCheese();
            iBuilder.BuildProtein();
            iBuilder.BuildVegetable();
            iBuilder.BuildDescription();
        }

        public Pizza FinalPizza()
        {
            return iBuilder.GetPizza();
        }
    }
}
