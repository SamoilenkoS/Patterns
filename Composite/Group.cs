using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Group : IComponent
    {
        public List<IComponent> Members { get; set; }
        public string Name { get; set; }

        public Group()
        {
            Members = new List<IComponent>();
        }

        public int Gold
        {
            get
            {
                return Members.Sum(member => member.Gold);
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats()
        {
            Members.ForEach(member => member.Stats());
        }
    }
}
