using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aseassign
{
    public class sqandrecex : Exception
    {
        public sqandrecex(Graphics j, int ypos) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("provide appropiate parameters to rectangle", fr, Brushes.Purple, new Point(0, ypos));

        }
    }
}
