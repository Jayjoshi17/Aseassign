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
        /// This is the constructor of if loop.
        /// </summary>
        /// <param name="j">This is the object of Graphics to draw shapes </param>
        /// <param name="condition">It checks the conditions wether the value enter by the users are in the condition list or not.</param>
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
