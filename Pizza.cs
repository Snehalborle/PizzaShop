using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzashop
{
    /// <summary>
    ///  Pizza Class
    /// </summary>
    internal class Pizza
    {
        public virtual string Prepare()
        {
            return "Being Prepared";
        }

        public string Bake()
        {
            return "Baking Done";
        }

        public string Cut()
        {
            return "Cutting Done";
        }

        public string Box()
        {
            return "Packing Box";
        }

    }
}

