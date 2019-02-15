namespace Builder
{
    public class AnotherHomeBuilder : AHomeBuilder
    {
        public override void FundamentCreate()
        {
            Home.FundamentOptions = FundamentOptions.WithHiddenRoom;
        }

        public override void HouseBasicCreate()
        {
            Home.HouseMaterial = HouseMaterial.Fire;
        }

        public override void RoofCreate()
        {
            Home.RoofType = RoofType.TripleListed;
        }
    }
}
