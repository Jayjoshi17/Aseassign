using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class ifexec : Exception
    {
        public ifexec(Graphics j, int ypos) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Not valid 'if' command", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
