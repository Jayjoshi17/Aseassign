using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class openbt
    {
        public void open(object sd)
        {
                 if (sd is null)
            {
                throw new ArgumentNullException(nameof(sd));
            }
        }
    }
}