using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Tomatoes : ComponentDecorator
    {
        public Tomatoes(Component component)
            :base(component)
        {

        }
        public override string Description()
        {
            return base.Description() + "+Tomatoes";
        }

        public override double Price()
        {
            double decoratorBPrice = 2;
            return base.Price() + decoratorBPrice;
        }
    }
}
