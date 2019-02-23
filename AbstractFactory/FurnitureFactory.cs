namespace DesignPatterns
{
    abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();

        public abstract Sofa CreateSofa();

        public abstract CoffeTable CreateCoffeTable();
    }
}
