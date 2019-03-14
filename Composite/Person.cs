using System;

namespace Composite
{
    public class Person : IComponent
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        public void Stats()
        {
            Console.WriteLine($"{Name} has {Gold} gold coins.");
        }
    }
}