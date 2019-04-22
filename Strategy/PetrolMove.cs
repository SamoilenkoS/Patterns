using System;

namespace Strategy
{
    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Mooving on pertol");
        }
    }
}
