using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FurnitureFactory furnitureFactory = new VictorianFurnitureFactory();
            furnitureFactory.CreateSofa();
            furnitureFactory.CreateCoffeTable();
            Console.WriteLine();

            furnitureFactory = new ModernFurnitureFactory();
            furnitureFactory.CreateChair();

            Console.ReadKey();
        }
    }
}
