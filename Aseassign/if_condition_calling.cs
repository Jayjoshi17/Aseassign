using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// 
    /// </summary>
    public class if_condition_calling
    {
        String code;
        String fillvalue;
        Graphics j;
        List<string> var = new List<string>();
        List<string> val = new List<string>();
        /// <summary>
        /// This is a class of if condition for calling shapes.
        /// </summary>
        /// <param name="command"></param>
        /// <param name="j">This is the drawing object of Graphics</param>
        /// <param name="fillvalue">Here the user can fill their values</param>
        /// <param name="var">this is for variable </param>
        /// <param name="val">this indicate values</param>
        /// <exception cref="ArgumentNullException"></exception>
        public if_condition_calling(String command, Graphics j, String fillvalue, List<string> var, List<string> val)
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            this.code = command;
            this.fillvalue = fillvalue;
            this.j = j;
            this.var = var;
            this.val = val;
        }
        /// <summary>
        /// this is the method of it.
        /// </summary>
        public void comm()
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
            {
                if (int.TryParse(sp_command[1], out _))
                {
                    String rectangle = sp_command[1].Trim() + " " + int.Parse(sp_command[1]) + " " + int.Parse(sp_command[2]);
                    ddraw dr = new ddraw();
                    dr.draw(j, rectangle, fillvalue);
                }
                else
                {
                    int ele = var.IndexOf(sp_command[1].Trim());
                    int ele2 = var.IndexOf(sp_command[2].Trim());
                    String rect = sp_command[0].Trim() + " " + val[ele] + " " + val[ele2];
                    ddraw dr = new ddraw();
                    dr.draw(j, rect, fillvalue);
                }

            }
            if (sp_command[0] == "drawto")
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
                    int ele2 = var.IndexOf(sp_command[2].Trim());
                    String drawto = sp_command[0].Trim() + " " + val[ele] + " " + val[ele2];
                    ddraw dr = new ddraw();
                    dr.draw(j, drawto, fillvalue);

                }
            }
            if (sp_command[0] == "square")
            {
                if (int.TryParse(sp_command[1], out _))
                {
                    String rectangle = sp_command[1].Trim() + " " + int.Parse(sp_command[1]) + " " + int.Parse(sp_command[2]);
                    ddraw dr = new ddraw();
                    dr.draw(j, rectangle, fillvalue);
                }
                else
                {
                    int ele = var.IndexOf(sp_command[1].Trim());
                    int ele2 = var.IndexOf(sp_command[2].Trim());
                    String rect = sp_command[0].Trim() + " " + val[ele] + " " + val[ele2];
                    ddraw dr = new ddraw();
                    dr.draw(j, rect, fillvalue);
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
                vb_op vp = new vb_op(val, var);
                int element = var.IndexOf(sp_command[2]);
                val[element] = vp.n_w(code);
            }
            if (sp_command[0] == "triangle")
            {
                String[] first_value = sp_command[1].Split(',');
                String[] second_value = sp_command[2].Split(',');
                String[] third_value = sp_command[3].Split(',');
                if ((int.TryParse(first_value[0], out _) && int.TryParse(first_value[1], out _)) && (int.TryParse(second_value[0], out _) && int.TryParse(second_value[1], out _)) && (int.TryParse(third_value[0], out _) && int.TryParse(third_value[1], out _)))
                {
                    ddraw dr = new ddraw();
                    dr.draw(j, code, fillvalue);
                }


                else if (var.Contains(first_value[0]) && var.Contains(first_value[1]) && var.Contains(second_value[0]) && var.Contains(second_value[1]) && var.Contains(second_value[1]) && var.Contains(third_value[0]) && var.Contains(third_value[1]))
                      {
                    int element = var.IndexOf(first_value[0]);
                    int element1 = var.IndexOf(first_value[1]);
                    int element2 = var.IndexOf(first_value[0]);
                    int element3 = var.IndexOf(first_value[1]);
                    int element4 = var.IndexOf(first_value[0]);
                    int element5 = var.IndexOf(first_value[1]);
                    String square_command = sp_command[0] + " " + val[element] + "," + val[element1] + " " + val[element2] + "," + val[element3] + " " + val[element4] + "," + val[element5];
                    ddraw dr = new ddraw();
                    dr.draw(j, square_command, fillvalue);
                }
            }
        }
    }
}

