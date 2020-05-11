using System.Collections.Generic;

namespace Flyweight
{
    public class TileFactory
    {
        private static Dictionary<string, ITile> tiles = new Dictionary<string, ITile>();
        private const string STONE = "Stone";

        static TileFactory()
        {

        }

        public static ITile GetTile(string tileType)
        {
            switch (tileType)
            {
                case STONE:
                    if (!tiles.ContainsKey(STONE))
                    {
                        tiles[STONE] = new StoneTile();
                    }

                    return tiles[STONE];
            }

            return null;
        }
    }
}
