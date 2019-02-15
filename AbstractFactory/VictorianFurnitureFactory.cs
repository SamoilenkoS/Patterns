using System;

namespace DesignPatterns
{
    class VictorianFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            VictorianChair victorianChair = new VictorianChair();
            Console.WriteLine("Get your victorian chair.");
            return victorianChair;
        }

        public override CoffeTable CreateCoffeTable()
        {
            VictorianCoffeTable victorianCoffeTable = new VictorianCoffeTable();
            Console.WriteLine("Get your victorian coffe table.");
            return victorianCoffeTable;
        }

        public override Sofa CreateSofa()
        {
            VictorianSofa victorianSofa = new VictorianSofa();
            Console.WriteLine("Get your victorian sofa.");
            return victorianSofa;
        }
    }
}
