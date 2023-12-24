using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class clear
    {
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
