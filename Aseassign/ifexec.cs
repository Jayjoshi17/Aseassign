using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is the if loop exception
    /// </summary>
    public class ifexec : Exception
    {
        /// <summary>
        /// This is the if exception constructor 
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="ypos">This is a position of axis on which the conditions where apply</param>
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
