using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class Circle
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public void draw(Graphics j, Pen p, int xpos, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            j.DrawEllipse(p, xpos, ypos, radius, radius);
        }
        public void drawfill(Graphics j, Brush brush, int xpos, int ypos)
        {
            if(j is null)
            {
                throw new ArgumentException(nameof(j));
            }
            j.FillEllipse(brush, xpos, ypos, radius, radius);
        }
    }
}
