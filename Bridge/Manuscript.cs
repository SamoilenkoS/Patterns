namespace Bridge
{
    public abstract class Manuscript
    {
        protected IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }
        public abstract void Print();
    }
}