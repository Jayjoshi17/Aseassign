using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class invalidmulti : Exception
    {
        public invalidmulti(Graphics j, int line) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("please enter a valid command in the line" + (line + 1) + "!", fr, Brushes.Purple, new Point(50, 50));
        }   
    }
}
