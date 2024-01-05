using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class trianglexc : Exception
    {
        public trianglexc(Graphics j, int ypos) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Give vaild command of triangle", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
