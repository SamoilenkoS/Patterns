using System;

namespace DesignPatterns
{
    class ModernChair : Chair
    {
        public override void HasLegs()
        {
            Console.WriteLine("Has no legs.");
        }

        public override void SitOn()
        {
            Console.WriteLine("You can sit on it.");
        }
    }
}
