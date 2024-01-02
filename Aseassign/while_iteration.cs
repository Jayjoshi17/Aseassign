using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aseassign
{
    public class while_iteration
    {
        Graphics j;
        String fillvalue;
        String command;
        public while_iteration(String command, Graphics j, string fillvalue)
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
