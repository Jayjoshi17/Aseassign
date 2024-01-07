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
    /// This is class file of to calling while iteration
    /// </summary>
    public class while_iteration
    {
        Graphics j;
        String fillvalue;
        String command;
        /// <summary>
        /// Their is a constructor of while iteration below it.
        /// </summary>
        /// <param name="command">To store String</param>
        /// <param name="j">This is a object for drawing of Graphics</param>
        /// <param name="fillvalue">Used to fill the value</param>
        /// <exception cref="ArgumentNullException">An exception that will be thrown whenever the value of graphic is null</exception>
        public while_iteration(String command, Graphics j,String fillvalue)
        {
           if(j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            this.j = j;
            this.fillvalue = fillvalue;
            this.command = command;
        }
        public void iterate()
        {
            String code = command + "\n" + "hello";
            Font fr = new Font("Arial", 14);
            j.DrawString(code, fr, Brushes.Purple, new Point(50, 50));
        }
    }
}
