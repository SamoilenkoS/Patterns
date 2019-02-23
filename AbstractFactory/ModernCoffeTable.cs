using System;

namespace DesignPatterns
{
    class ModernCoffeTable : CoffeTable
    {
        public override void ForDinner()
        {
            Console.WriteLine("No food on it.");
        }

        public override void HasLegs()
        {
            Console.WriteLine("Has 2 legs.");
        }

        public override void SitOn()
        {
            Console.WriteLine("You can sit on it.");
        }
    }
}
