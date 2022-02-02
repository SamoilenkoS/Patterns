using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PizzaBody : Component
    {
        public override string Description()
        {
            return "Pizza body";
        }

        public override double Price()
        {
            return 3;
        }
    }
}
