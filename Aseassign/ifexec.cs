using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// 
    /// </summary>
    public class ifexec : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="ypos"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ifexec(Graphics j, int ypos) 
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Not valid 'if' command", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
