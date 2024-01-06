using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is the exception of reset class
    /// </summary>
    public class resetex : Exception
    {
        /// <summary>
        /// Their is the constructor of reset
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="ypos">This is the y-axis</param>
        /// <exception cref="ArgumentNullException"></exception>
        public resetex(Graphics j, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Give valid command of Reset", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
