using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class if_condition
    {
        String condition;
        Char[] characters;
        Graphics j;
        public if_condition(Graphics j, String condition)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            this.condition = condition;
            this.j = j;
        }
        public string if_statement()
        {
            List<String> list = new List<string>();
            list.Add("==");
            list.Add("<=");
            list.Add(">=");
            list.Add(">");
            list.Add("<");
            list.Add("!=");
            if (list.Contains(condition))
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
