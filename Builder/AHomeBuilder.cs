namespace Builder
{
    public abstract class AHomeBuilder
    {
        protected Home Home;
        public Home GetHome()
        {
            return Home;
        }
        public void CreateHome()
        {
            Home = new Home();
        }

        public abstract void FundamentCreate();
        public abstract void HouseBasicCreate();
        public abstract void RoofCreate();
    }
}
