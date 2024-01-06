using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is the class for multiline invalid command
    /// </summary>
    public class invalidmulti : Exception
    {
        /// <summary>
        /// In this class file their is constructor of invalidmultiline 
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="line">It indicates that which specific line is invalid.</param>
        public invalidmulti(Graphics j, int line) 
        {
            Font fr = new Font("Arial", 14);
            j.DrawString("please enter a valid command in the line" + (line + 1) + "!", fr, Brushes.Purple, new Point(50, 50));
        }   
    }
}
