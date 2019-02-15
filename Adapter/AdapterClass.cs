namespace Adapter
{
    public class AdapterClass : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}