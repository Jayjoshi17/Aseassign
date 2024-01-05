using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is a fill class file in which user can fill color in it. 
    /// </summary>
    public class fill
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="j">This is the parameters of Graphics to draw a shapes</param>
        /// <exception cref="ArgumentNullException"></exception>
        public fill(Graphics j) 
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
        }
        public string fillvalue = "on";
    }
}
