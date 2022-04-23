using Pizzashop.Wellknowns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzashop
{
///
    internal class OrderPizza
    {
        public string Create(PizzaTypeEnum pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaTypeEnum.Pepperoni:
                    PepperoniPizza pepperoniPizza = new PepperoniPizza();
                    pepperoniPizza.Prepare();
                    pepperoniPizza.Bake();
                    pepperoniPizza.Cut();
                    pepperoniPizza.Box();
                    return "Pepperoni pizza ready for delivery";

                case PizzaTypeEnum.Margherita:
                    MargheritaPizza margheritaPizza = new MargheritaPizza();
                    margheritaPizza.Prepare();
                    margheritaPizza.Bake();
                    margheritaPizza.Cut();
                    margheritaPizza.Box();
                    return "Margherita pizza ready for delivery";

                case PizzaTypeEnum.Hawaiian:
                    HawaiianPizza hawaiianPizza = new HawaiianPizza();
                    hawaiianPizza.Prepare();
                    hawaiianPizza.Bake();
                    hawaiianPizza.Cut();
                    hawaiianPizza.Box();
                    return "Hawaiian pizza ready for delivery";

                default:
                    return "Pizza is not Available";
            }
           
        }
    }
}
