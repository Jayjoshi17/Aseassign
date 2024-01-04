using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class save
    {
        public save(object sd)
        {   
            if(sd is null)
            {
                throw new ArgumentNullException(nameof(sd));    
            }
        }
    }
}
