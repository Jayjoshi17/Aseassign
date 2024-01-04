using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is my first class of shapes circle in which users can enter the radius
    /// as per their need.
    /// </summary>
    public class Circle
    {
        private int radius;
        /// <summary>
        /// Here a constructor is made by me that will take the radius which will processed by user.
        /// </summary>
        /// <param name="radius">It aid a circle to draw it with radius</param>
        public Circle(int radius)
        {
            this.radius = radius;
        }
        /// <summary>
        ///The non filled circle will drawn by this method. 
        /// </summary>
        /// <param name="j">This line of code will be seen in each and every class because this is
        /// an important Graphic variable which aid to draw circle</param>
        /// <param name="p">this will help to draw a object is it pen</param>
        /// <param name="xpos">for draw any object their are 2 positions in them so here this is
        /// x-position to draw circle</param>
        /// <param name="ypos">for draw any object their are 2 positions in them so here this is
        /// y-position to draw circle</param>
        /// <exception cref="ArgumentNullException">This will thrown an expection if graphic variable
        /// is null</exception>
        public void draw(Graphics j, Pen p, int xpos, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            j.DrawEllipse(p, xpos, ypos, radius, radius);
        }
        /// <summary>
        /// And this is for the filled circle 
        /// </summary>
        /// <param name="j">it is used for to draw a circle</param>
        /// <param name="brush">To a draw a circle brush is used</param>
        /// <param name="xpos">It is on the canvas where circle is to be drawn.</param>
        /// <param name="ypos">on the canvas it is y-pos from which circle can be drawn</param>
        /// <exception cref="ArgumentException">This will thrown an expection if graphic variable
        /// is null</exception>
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
