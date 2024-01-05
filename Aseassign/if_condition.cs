using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is a class of if condition it works in loop
    /// </summary>
    public class if_condition
    {
        String condition;
        Char[] characters;
        Graphics j;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes </param>
        /// <param name="condition"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public if_condition(Graphics j, String condition)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            this.condition = condition;
            this.j = j;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
