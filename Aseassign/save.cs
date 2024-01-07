using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is the class for save the text file
    /// </summary>
    public class save
    {
        /// <summary>
        /// To the below of it their is a constructor of save class.
        /// </summary>
        /// <param name="sd">It is the object of save</param>
        /// <exception cref="ArgumentNullException"></exception>
        public save(object sd)
        {   
            if(sd is null)
            {
                throw new ArgumentNullException(nameof(sd));    
            }
        }
    }
}
