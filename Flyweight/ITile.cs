using System.Drawing;

namespace Flyweight
{
    public interface ITile
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }
}
