using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aseassign
{
    /// <summary>
    /// This exception class is for square and rectangle 
    /// </summary>
    public class sqandrecex : Exception
    {
        /// <summary>
        /// Their is a constructor of square and rectangle just below it.
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="ypos">This is for the y-axis</param>
        /// <exception cref="ArgumentNullException"></exception>
        public sqandrecex(Graphics j, int ypos) 
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("provide appropiate parameters to rectangle", fr, Brushes.Purple, new Point(0, ypos));

        }
    }
}
