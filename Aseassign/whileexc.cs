using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is an exception class of while loop
    /// </summary>
    public class whileexc : Exception
    {
        /// <summary>
        /// Their is a constructor of while in below
        /// </summary>
        /// <param name="j">This is a object for drawing of Graphics</param>
        /// <param name="ypos">Idicates y-axis</param>
        /// <exception cref="ArgumentNullException">An exception that will be thrown whenever the value of graphic is null</exception>
        public whileexc(Graphics j, int ypos)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Invalid 'while' command", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
