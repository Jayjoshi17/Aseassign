using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is the class of variable operation
    /// </summary>
    public class vb_op
    {
        List<String> val;
        List<String> var;
        public vb_op(List<String> val, List<String> var)
        {
            if (val is null)
            {
                throw new ArgumentNullException(nameof(val));
            }
            this.val = val;
            this.var = var;
        }
        /// <summary>
        /// Their is a method of variable operation in below
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public String n_w(String operation)
        {
            String[] sp_command = operation.Split(' ');
            int element = var.IndexOf(sp_command[2]);
            if (sp_command[3] == "+")
            {
                int aa = int.Parse(sp_command[4]);
                int bb = int.Parse(val[element]);
                int n_w = aa + bb;
                return n_w.ToString();
            }
            if (sp_command[3] == "-")
            {
                int aa = int.Parse(sp_command[4]);
                int bb = int.Parse(val[element]);
                int n_w = bb - aa;
                return n_w.ToString();

            }
            if (sp_command[3] == "*")
            {
                int aa = int.Parse(sp_command[4]);
                int bb = int.Parse(val[element]);
                int n_w = aa * bb;
                return n_w.ToString();
            }
            if (sp_command[3] == "/")
            {
                int aa = int.Parse(sp_command[4]);
                int bb = int.Parse(val[element]);
                int n_w = aa / bb;
                return n_w.ToString();
            }
            return "Jay Shree Ram";
        }
    }
}
