using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class while_loop
    {
        String condition;
        public while_loop(string condition)
        {
            if (condition == null)
            {
                throw new ArgumentNullException(nameof(condition));
            }
            this.condition = condition;
        }
        public String validation()
        {
            List<String> result = new List<String>();
            list.Add("==");
            list.Add("<=");
            list.Add(">=");
            list.Add("!=");
            list.Add(">");
            list.Add("<");
            if(List.Contains(condition))
            {
                return condition;
            }
            else
            {
                return condition;
            }

        }
    }
}
