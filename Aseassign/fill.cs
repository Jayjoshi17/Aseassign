using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class fill
    {
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
