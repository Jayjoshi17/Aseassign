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
        public void draw(Graphics j, Pen p, int xpos, int ypos,int jm1, int jm2, int mj1, int mj2, int mp1, int mp2)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Point[] points = { new Point(jm1, jm2), new Point(mj1, mj2), new Point(mp1, mp2)};
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
        public void drawfill(Graphics j, Brush brush, int xpos, int ypos, int jm1, int jm2, int mj1, int mj2, int mp1, int mp2)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Point[] points = { new Point(jm1, jm2), new Point(mj1, mj2), new Point(mp1, mp2) };
            j.FillPolygon(brush, points);
        }
    }
}
