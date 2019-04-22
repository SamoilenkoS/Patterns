using System;

namespace State
{
    class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Liquid water => Gas water");
            water.State = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Liquid water => Solid water");
            water.State = new SolidWaterState();
        }
    }
}
