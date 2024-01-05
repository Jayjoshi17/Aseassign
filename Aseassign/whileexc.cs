using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class whileexc : Exception
    {
        public whileexc(Graphics j, int ypos)
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Invalid 'while' command", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
