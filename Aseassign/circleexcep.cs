using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is the cirlce exception class file.
    /// </summary>
    public class circleexcep : Exception
    {
        /// <summary>
        /// In this if user do not enter proper parameters then they will get this meaasge that wtitten below.
        /// </summary>
        /// <param name="j">This is a object of Graphics for Drawing</param>
        /// <param name="ypos">This is for the variable </param>
        /// <exception cref="ArgumentNullException"></exception>
        public circleexcep(Graphics j,int ypos) 
        {
            
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            Font fr = new Font("Arial", 14);
            j.DrawString("Provide decent parameters of circle ", fr, Brushes.Purple, new Point(0, ypos));
        }
    }
    
    }

