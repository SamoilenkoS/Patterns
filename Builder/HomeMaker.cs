namespace Builder
{
    public class HomeMaker
    {
        private readonly AHomeBuilder homeBuilder;
        public HomeMaker(AHomeBuilder homeBuilder)
        {
            this.homeBuilder = homeBuilder;
        }

        public void BuildHome()
        {
            homeBuilder.CreateHome();
            homeBuilder.FundamentCreate();
            homeBuilder.HouseBasicCreate();
            homeBuilder.RoofCreate();
        }

        public Home GetHome()
        {
            return homeBuilder.GetHome();
        }
    }
}
