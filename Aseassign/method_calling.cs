﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is class of method and it will call when method does not have any parameters.
    /// </summary>
    public class method_calling
    {
        String code;
        String fillvalue;
        Graphics j;
        List<string> var = new List<string>();
        List<string> val = new List<string>();
        /// <summary>
        /// Here their is constructor of method calling just below it.
        /// </summary>
        /// <param name="code">It is a method block in the command</param>
        /// <param name="j">It use for to draw the shapes by Graphics</param>
        /// <param name="fillvalue">It is for the vale can be filled by which user passes</param>
        /// <param name="var">For the list of variable</param>
        /// <param name="val">list of created variables values</param>
        /// <exception cref="ArgumentNullException"></exception>
        public method_calling(String code, Graphics j, String fillvalue, List<string> var, List<string> val)
        {
            if(j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            this.code = code; ;
            this.fillvalue = fillvalue;
            this.j = j;
            this.var = var;
            this.val = val;
        }
        /// <summary>
        /// This cmds method will call classes of the command passed in the method block.
        /// </summary>
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
