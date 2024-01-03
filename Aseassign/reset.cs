using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
   public class reset
    {
        public reset(String commandline, String multiline)
        {
            if (commandline is null)
            {
                throw new ArgumentNullException(nameof(commandline));
            }
            commandline = " ";
            multiline = " ";
        }
        public String do_reset()
        {
            return " ";
        }
    }
}
