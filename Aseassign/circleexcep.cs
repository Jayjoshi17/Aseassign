using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    internal class circleexcep : Exception
    {
        public circleexcep(Graphics j) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("Provide decent parameters of circle ", fr, Brushes.Purple, new Point(50, 50));
        }
    }
    
    }

