using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class Rectangle
    {
        private int Height, Width;

        public Rectangle(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public void draw(Graphics j, Pen p)
        {
            if (j == null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            j.DrawRectangle(p, 0, 0, Height, Width);
        }
    }
}
