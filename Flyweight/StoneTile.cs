using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class StoneTile : ITile
    {
        public static int ObjectCounter = 0;

        private Brush paintBrush;

        public StoneTile()
        {
            paintBrush = Brushes.Blue;
            ++ObjectCounter;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
