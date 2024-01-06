using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is a exception of empty command line 
    /// </summary>
    public class emptycmdexc : Exception
    {
        /// <summary>
        /// 
        /// </sumIf user do not enter any values then they will get message as seen in below>
        /// <param name="j">It is a object which used for drawing from Graphics</param>
        /// <param name="ypos">This is the position for on which axix they have to draw</param>
        /// <exception cref="ArgumentNullException"></exception>
        public emptycmdexc(Graphics j, int ypos) 
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Here the command line is empty", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
