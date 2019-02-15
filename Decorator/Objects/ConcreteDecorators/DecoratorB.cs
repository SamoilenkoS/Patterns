using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DecoratorB : ComponentDecorator
    {
        public DecoratorB(Component component)
            :base(component)
        {

        }
        public override string Description()
        {
            return base.Description() + " Decorator B extension";
        }

        public override double Price()
        {
            double decoratorBPrice = 2.3;
            return base.Price() + decoratorBPrice;
        }
    }
}
