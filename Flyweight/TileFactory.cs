using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TileFactory
    {
        private static Dictionary<string, ITile> tiles = new Dictionary<string, ITile>();

        static TileFactory()
        {

        }

        public static ITile GetTile(string tileType)
        {
            switch (tileType)
            {
                case "Stone":
                    if (!tiles.ContainsKey("Stone"))
                    {
                        tiles["Stone"] = new StoneTile();
                    }
                    return tiles["Stone"];
            }

            return null;
        }
    }
}
