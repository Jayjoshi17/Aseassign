using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class emptycmdexc : Exception
    {
        public emptycmdexc(Graphics j, int ypos) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Here the command line is empty", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
