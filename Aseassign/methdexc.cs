﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class methdexc : Exception
    {
        public methdexc(Graphics j, int ypos) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Not a valid 'method' command", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
}
