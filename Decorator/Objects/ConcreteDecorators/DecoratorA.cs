using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DecoratorA : ComponentDecorator
    {
        public DecoratorA(Component component)
            :base(component)
        {

        }
        public override string Description()
        {
            return base.Description() + " Decorator A extension";
        }

        public override double Price()
        {
            double decoratorAPrice = 1.5;
            return base.Price() + decoratorAPrice;
        }
    }
}
