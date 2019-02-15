using System;

namespace DesignPatterns
{
    class VictorianChair : Chair
    {
        public override void HasLegs()
        {
            Console.WriteLine("Has 4 legs.");
        }

        public override void SitOn()
        {
            Console.WriteLine("You can sit on it.");
        }
    }
}
