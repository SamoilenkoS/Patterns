using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ComponentDecorator : Component
    {
        protected Component _component;
        public ComponentDecorator(Component component)
        {
            _component = component;
        }

        public override string Description()
        {
            return _component.Description();
        }

        public override double Price()
        {
            return _component.Price();
        }
    }
}
