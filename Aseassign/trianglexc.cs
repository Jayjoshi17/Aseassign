using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is class of exception of triangle
    /// </summary>
    public class trianglexc : Exception
    {
        /// <summary>
        /// This is an constructor of triangle
        /// </summary>
        /// <param name="j">This is a object for drawing of Graphics</param>
        /// <param name="ypos">This is for y-axis</param>
        /// <exception cref="ArgumentNullException">An exception that will be thrown whenever the value of graphic is null</exception>
        public trianglexc(Graphics j, int ypos) 
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Give vaild command of triangle", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
