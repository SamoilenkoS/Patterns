using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cheeze : ComponentDecorator
    {
        public Cheeze(Component component)
            :base(component)
        {

        }

        public override string Description()
        {
            return base.Description() + " + Cheeze";
        }

        public override double Price()
        {
            double decoratorAPrice = 1.5;
            return base.Price() + decoratorAPrice;
        }
    }
}
