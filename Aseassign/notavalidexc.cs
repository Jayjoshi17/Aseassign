using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is for the not a valid exception.
    /// </summary>
    public class notavalidexc : Exception
    {
        /// <summary>
        /// I made a one constructor of not a vaild class
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="ypos">This is for the position of y-axis</param>
        /// <exception cref="ArgumentNullException"></exception>
        public notavalidexc(Graphics j, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Enter a valid command", fr, Brushes.Purple, new Point(0, ypos));
        
        }
    }
}
