﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class cexc : Exception
    {
        public cexc(Graphics j,int y) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Provide proper command for clear", fr, Brushes.Purple, new Point(0, y));
        }
    }
}
