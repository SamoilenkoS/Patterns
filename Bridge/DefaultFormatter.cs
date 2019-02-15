namespace Bridge
{
    public class DefaultFormatter : IFormatter
    {
        public string Format(string title, string description)
        {
            return string.Format($"{title}: {description}");
        }
    }
}
