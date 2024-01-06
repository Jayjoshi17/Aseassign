using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// Thisis the reset class for to reset the values which was entered by users.
    /// </summary>
   public class reset
    {
        /// <summary>
        /// In this class their is a constructor of reset
        /// </summary>
        /// <param name="commandline">This indicates the commandline values</param>
        /// <param name="multiline">It indicates the multiline values</param>
        /// <exception cref="ArgumentNullException"></exception>
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
