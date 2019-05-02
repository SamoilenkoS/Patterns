using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable movable = new PetrolMove();
            Car auto = new Car(4, "Volvo", movable);
            auto.Move();
            movable = new ElectricMove();
            auto = new Car(2, "Tesla", movable);
            auto.Move();

            Console.ReadKey();
        }
    }
}
