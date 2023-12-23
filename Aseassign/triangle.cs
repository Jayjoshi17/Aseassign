using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class triangle
    {
        public triangle(Graphics j, Pen p)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
        }
        public void draw(Graphics j, Pen p, int xpos, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Point[] points = { new Point(9, 80), new Point(100, 10), new Point(150, 200) };
            j.DrawPolygon(j, points);
        }
        public void drawfill(Graphics j, Brush brush, int xpos, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Point[] points = { new Point(9, 100), new Point(112, 10), new Point(150, 100) };
            j.FillPolygon(brush, points);
        }
    }
}
