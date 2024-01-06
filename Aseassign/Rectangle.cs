using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is a rectangle class 
    /// </summary>
    public class Rectangle
    {
        private int Height, Width;
        /// <summary>
        /// Below it is a constructor of rectangle 
        /// </summary>
        /// <param name="Height">It mesaure a height</param>
        /// <param name="Width">It measure a width</param>
        public Rectangle(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        /// <summary>
        /// This below method is to draw rectangle
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="p">This is the object of pen to draw shapes</param>
        /// <param name="xpos">This is for x-axis value</param>
        /// <param name="ypos">This is for the y-axis value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void draw(Graphics j, Pen p, int xpos, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            j.DrawRectangle(p, xpos, ypos, Height, Width);
        }
        /// <summary>
        /// The below method is for draw the fill rectangle with colour.
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="brush">It is used for to add colours</param>
        /// <param name="xpos">this is the x-axis coordinates</param>
        /// <param name="ypos">this is for the y-axis coordinates</param>
        /// <exception cref="ArgumentNullException"></exception>

        public void drawfill(Graphics j, Brush brush, int xpos, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            j.FillRectangle(brush, xpos, ypos, Height, Width);
        }
    }
}