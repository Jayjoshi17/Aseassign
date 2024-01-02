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
        public while_loop(String condition)
        {
            if (condition is null)
            {
                throw new ArgumentNullException(nameof(condition));
            }
            this.condition = condition;
        }
        public String validation()
        {
            List<String> result = new List<String>();
            result.Add("==");
            result.Add("<=");
            result.Add(">=");
            result.Add("!=");
            result.Add(">");
            result.Add("<");
            if(result.Contains(condition))
            {
                return condition;
            }
            else
            {
                return "false";
            }

        }
    }
}
