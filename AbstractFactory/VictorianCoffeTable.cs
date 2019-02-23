using System;

namespace DesignPatterns
{
    class VictorianCoffeTable : CoffeTable
    {
        public override void ForDinner()
        {
            Console.WriteLine("No food on it.");
        }

        public override void HasLegs()
        {
            Console.WriteLine("Has 4 legs.");
        }

        public override void SitOn()
        {
            Console.WriteLine("You can`t sit on it.");
        }
    }
}
