using System.Linq;

namespace Bridge
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string title, string description)
        {
            return string.Format($"{title}: {new string(description.Reverse().ToArray())}");
        }
    }
}
