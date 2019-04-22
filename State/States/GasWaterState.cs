using System;

namespace State
{
    class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Heating gas...");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Gas => Liquid water");
            water.State = new LiquidWaterState();
        }
    }
}
