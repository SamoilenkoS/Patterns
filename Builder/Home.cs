using System;

namespace Builder
{
    public class Home
    {
        public RoofType RoofType { get; set; }
        public HouseMaterial HouseMaterial { get; set; }
        public FundamentOptions FundamentOptions { get; set; }

        public void Display()
        {
            Console.WriteLine($"Roof:{RoofType}{Environment.NewLine}House material:{HouseMaterial}{Environment.NewLine}Fundament options:{FundamentOptions}");
        }
    }

    public enum RoofType
    {
        Basic,
        DoubleListed,
        TripleListed
    }
    public enum HouseMaterial
    {
        Wood,
        Stone,
        Fire
    }
    public enum FundamentOptions
    {
        None,
        WithHiddenRoom,
        WithBasement
    }
}
