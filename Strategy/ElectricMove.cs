using System;

namespace Strategy
{
    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Electric car moove");
        }
    }
}
