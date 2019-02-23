using System;

namespace DesignPatterns
{
    class VictorianSofa : Sofa
    {
        public override void CanSleep()
        {
            Console.WriteLine("You better sleep in other place.");
        }

        public override void HasLegs()
        {
            Console.WriteLine("Has 4 legs.");
        }

        public override void SitOn()
        {
            Console.WriteLine("You can sit here.");
        }
    }
}
