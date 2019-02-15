using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            VictorianFurnitureFactory victorianFurniture = new VictorianFurnitureFactory();
            victorianFurniture.CreateSofa();
            victorianFurniture.CreateCoffeTable();
            Console.WriteLine();

            ModernFurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();
            modernFurnitureFactory.CreateChair();

            Console.ReadKey();
        }
    }
}
