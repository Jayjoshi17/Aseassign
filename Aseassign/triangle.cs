using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This class is for the triangle 
    /// </summary>
    public class triangle
    {
        /// <summary>
        /// Theri is a constructor of triangle class
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="p">This is the object of pen to draw shapes</param>
        /// <exception cref="ArgumentNullException">An excpetion will be thrown when value ot the graphic variable is null</exception>
        public triangle(Graphics j, Pen p)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
        }
        /// <summary>
        /// Their is a method of draw to triangle  
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="p">This is the object of Graphics to draw shapes</param>
        /// <param name="xpos">This is for the x-axis</param>
        /// <param name="ypos">This is for the y-axis</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void draw(Graphics j, Pen p, int xpos, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Point[] points = { new Point(9, 80), new Point(100, 10), new Point(150, 200) };
            j.DrawPolygon(p, points);
        }
        /// <summary>
        /// Their is a method of drawfill to triangle that fill the colours in it.
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="brush">This is the object of add colours</param>
        /// <param name="xpos">This is for the x-axis</param>
        /// <param name="ypos">This is for the y-axis</param>
        /// <exception cref="ArgumentNullException"></exception>
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
