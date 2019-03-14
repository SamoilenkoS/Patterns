using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Operation1();
            facade.Operation2();

            Console.ReadKey();
        }
    }
}