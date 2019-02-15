using System;

namespace DesignPatterns
{
    class ModernSofa : Sofa
    {
        public override void CanSleep()
        {
            Console.WriteLine("You can sleep here.");
        }

        public override void HasLegs()
        {
            Console.WriteLine("No legs. It's fashhion.");
        }

        public override void SitOn()
        {
            Console.WriteLine("You can sit here.");
        }
    }
}
