using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is a exception class of method condition
    /// </summary>
    public class methdexc : Exception
    {
        /// <summary>
        /// Here, I made a constructor of method condition
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="ypos">This is a postion where one axis values are stored</param>
        /// <exception cref="ArgumentNullException"></exception>
        public methdexc(Graphics j, int ypos) 
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Not a valid 'method' command", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
