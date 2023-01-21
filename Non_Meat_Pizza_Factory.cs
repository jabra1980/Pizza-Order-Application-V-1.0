using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Order
{
    public class Non_Meat_Pizza_Factory : Abstract_Factory
    {
        public override void CreatePizza()
        {
            
            IBuilder builder = new Veggie();
            Chief chief = new Chief(builder);

            chief.ConstructPizza();
            chief.FinalPizza().Display();
        }
    }
}
