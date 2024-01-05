using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class resetex : Exception
    {
        public resetex(Graphics j, int ypos)
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Give valid command of Reset", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
