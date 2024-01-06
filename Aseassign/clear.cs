using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// With the help of this canvas it clear the value whenever it is called.
    /// </summary>
    public class clear
    {
        /// <summary>
        /// This method will give it the purple color and draw the method will clear the whole 
        /// code.
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void draw(Graphics j)
        {
            if(j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            j.Clear(Color.Purple);
        }
    }
}
