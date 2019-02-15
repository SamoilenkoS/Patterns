using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ConcreteComponents : Component
    {
        public override string Description()
        {
            return "Concrete component";
        }

        public override double Price()
        {
            return 3;
        }
    }
}
