using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is for the open button by which the txt file gets open
    /// </summary>
    public class openbt
    {
        /// <summary>
        /// This is a method of open button
        /// </summary>
        /// <param name="sd"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void open(object sd)
        {
                 if (sd is null)
            {
                throw new ArgumentNullException(nameof(sd));
            }
        }
    }
}