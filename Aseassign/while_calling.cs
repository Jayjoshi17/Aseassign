using Aseassign;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aseassign
{
    /// <summary>
    /// This is class file of to calling while condition
    /// </summary>
    public class while_calling
    {
        String code;
        String fillvalue;
        Graphics j;
        List<string> var = new List<string>();
        List<string> val = new List<string>();
        /// <summary>
        /// Their is a constructor of while calling below it.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="j"></param>
        /// <param name="fillvalue"></param>
        /// <param name="var"></param>
        /// <param name="val"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public while_calling(String code, Graphics j, String fillvalue, List<string> var, List<string> val)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            this.code = code;
            this.fillvalue = fillvalue;
            this.j = j;
            this.var = var;
            this.val = val;
        }
        public void cmds()
        {
            String[] sp_command = code.Split(' ');
            if (sp_command[0] == "circle")
            {
                if (int.TryParse(sp_command[1], out _))
                {
                    String circle = sp_command[0].Trim() + " " + int.Parse(sp_command[1]);
                    ddraw dr = new ddraw();
                    dr.draw(j, circle, fillvalue);
                }
                else
                {
                    int ele = var.IndexOf(sp_command[1].Trim());
                    String circle = sp_command[0].Trim() + " " + val[ele].Trim();
                    ddraw dr = new ddraw();
                    dr.draw(j, circle, fillvalue);
                }
            }
            if (sp_command[0] == "rectangle")
                if (int.TryParse(sp_command[1], out _))
                {
                    String rectangle = sp_command[0].Trim() + " " + int.Parse(sp_command[1]) + " " + int.Parse(sp_command[2]);
                    ddraw dr = new ddraw();
                    dr.draw(j, rectangle, fillvalue);
                }
                else
                {
                    int ele = var.IndexOf(sp_command[1].Trim());
                    int ele_ = var.IndexOf(sp_command[2].Trim());
                    String recta = sp_command[0].Trim() + " " + val[ele] + " " + val[ele_];
                    ddraw dr = new ddraw();
                    dr.draw(j, recta, fillvalue);
                }

            if (sp_command[0] == "darwto")
            {
                if (int.TryParse(sp_command[1], out _))
                {
                    String drawto = sp_command[0].Trim() + " " + int.Parse(sp_command[1]) + " " + int.Parse(sp_command[2]);
                    ddraw dr = new ddraw();
                    dr.draw(j, drawto, fillvalue);
                }
                else
                {
                    int ele = var.IndexOf(sp_command[1].Trim());
                    int ele_ = var.IndexOf(sp_command[2].Trim());
                    String drawto = sp_command[0].Trim() + " " + val[ele] + " " + val[ele_];
                    ddraw dr = new ddraw();
                    dr.draw(j, drawto, fillvalue);
                }
            }
            if (sp_command[0] == "square")
            {
                if (int.TryParse(sp_command[1], out _))
                {
                    String rectangle = sp_command[0].Trim() + " " + int.Parse(sp_command[1]) + " " + int.Parse(sp_command[2]);
                    ddraw dr = new ddraw();
                    dr.draw(j, rectangle, fillvalue);
                }
                else
                {
                    int ele = var.IndexOf(sp_command[1].Trim());
                    int ele_ = var.IndexOf(sp_command[2].Trim());
                    String rectangle = sp_command[0].Trim() + " " + val[ele] + " " + val[ele_];
                    ddraw dr = new ddraw();
                    dr.draw(j, rectangle, fillvalue);
                }
            }
            if (sp_command[0] == "clear")
            {
                String clear = sp_command[0].Trim();
                ddraw dr = new ddraw();
                dr.draw(j, clear, fillvalue);
            }
            if (var.Contains(sp_command[0]) && sp_command[1] == "=" && (sp_command[2] == sp_command[0]))
                {
                vb_op vo = new vb_op(val, var);
                int ele = var.IndexOf(sp_command[2]);
                val[ele] = vo.n_w(code);
            }
            if (sp_command[0] == "triangle")
            {
                String[] first_value = sp_command[1].Split(' ');
                String[] second_value = sp_command[2].Split(' ');
                String[] third_value = sp_command[3].Split(' ');
                if ((int.TryParse(first_value[0], out _) && int.TryParse(first_value[1], out _)) && (int.TryParse(second_value[0], out _) && int.TryParse(second_value[1], out _)) && (int.TryParse(third_value[0], out _) && int.TryParse(third_value[1], out _)))
                    {
                    ddraw dr = new ddraw();
                    dr.draw(j, code, fillvalue);
                }
                else if (var.Contains(first_value[0]) && var.Contains(first_value[1]) && var.Contains(second_value[0]) && var.Contains(second_value[1]) && var.Contains(third_value[0]) && var.Contains(third_value[1]))
                {
                    int element = var.IndexOf(first_value[0]);
                    int element1 = var.IndexOf(first_value[1]);
                    int element2 = var.IndexOf(first_value[0]);
                    int element3 = var.IndexOf(first_value[1]);
                    int element4 = var.IndexOf(first_value[0]);
                    int element5 = var.IndexOf(first_value[1]);
                }
            }
        }
    }
}
