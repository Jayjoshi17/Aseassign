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
        public void draw(Graphics j, Pen p)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            j.DrawEllipse(p, 0, 0, radius, radius);
        }
    }
}
