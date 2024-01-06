using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is an exception of clear class file
    /// </summary>
    public class cexc : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="j">This is an object of Graphics which used for drawing</param>
        /// <param name="y">It is a variable value</param>
        /// <exception cref="ArgumentNullException"></exception>
        public cexc(Graphics j,int y) 
        {
            if(j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Provide proper command for clear", fr, Brushes.Purple, new Point(0, y));
        }
    }
}
