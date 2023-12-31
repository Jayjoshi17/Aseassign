﻿using System;
using Aseassign;
using Aseassign.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net;

namespace Aseassign
{ /// <summary>
/// This is the class of multiline text box from 
/// which command get entered from the user side one by one.
/// </summary>
    public class multiline
    {
        String cmds;
        String fillvalue;
        List<string> var = new List<string>();
        List<string> val = new List<string>();
        List<string> mth_vars = new List<string>();
        List<string> mth_vals = new List<string>();
        List<string> mthds = new List<string>();
        List<string> mthds_cmds = new List<string>();
        Graphics j;
        /// <summary>
        /// Here, a constructed is created which will take the value 
        /// of fill and whole code is in the multiline box and 
        /// for drawing objects their is a Graphics which will 
        /// assign to the global class variable.
        /// </summary>
        /// <param name="cmds"></param>
        /// <param name="j">This is the object of Graphics which works to draw</param>
        /// <param name="fillvalue">It is for to draw the shape is to drawn
        /// without or with fill</param>
        public multiline(String cmds, Graphics j, String fillvalue)
        {
            this.cmds = cmds;
            this.j = j;
            this.fillvalue = fillvalue;
        }
        /// <summary>
        /// This code plays a vital role in which all the commands and conditions will run
        /// by thier specific class and will include all the components like drawing, while, if
        /// and method loops.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void multiline_call()
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            List<string> acttable = new List<string>();
            acttable.Add("circle");
            acttable.Add("rectangle");
            acttable.Add("triangle");
            acttable.Add("square");
            acttable.Add("drawto");
            acttable.Add("clear");
            String[] lines = cmds.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                String[] sp_command = lines[i].Split(' ');

                // this code is for creation of variables.
                if (sp_command.Contains("="))
                {
                    val.Add(sp_command[2]);
                    var.Add(sp_command[0]);
                }
                // From here all the condition of drawing shapes are started. 
                if (acttable.Contains(sp_command[0]))
                {
                    sp_command[0].ToLower();
                    switch (sp_command[0])
                    {
                        case "circle":
                            if (int.TryParse(sp_command[1], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, cmds, fillvalue);
                            }
                            else if (var.Contains(sp_command[1]))
                            {

                                int element = var.IndexOf(sp_command[1]);
                                String circle_command = sp_command[0] + " " + val[element];
                                ddraw dr = new ddraw();
                                dr.draw(j, circle_command, fillvalue);
                            }
                            break;
                        case "rectangle":
                            if (int.TryParse(sp_command[1], out _) && int.TryParse(sp_command[2], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (var.Contains(sp_command[1]) && var.Contains(sp_command[2]))
                            {
                                int element = var.IndexOf(sp_command[1]);
                                int element2 = var.IndexOf(sp_command[2]);
                                String square_command = sp_command[0] + " " + val[element] + " " + val[element2];
                                ddraw dr = new ddraw();
                                dr.draw(j, square_command, fillvalue);
                            }
                            break;
                        case "square":
                            if (int.TryParse(sp_command[1], out _) && int.TryParse(sp_command[2], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (var.Contains(sp_command[1]) && var.Contains(sp_command[2]))
                            {
                                int element = var.IndexOf(sp_command[1]);
                                int element2 = var.IndexOf(sp_command[2]);
                                String square_command = sp_command[0] + " " + val[element] + " " + val[element2];
                                ddraw dr = new ddraw();
                                dr.draw(j, square_command, fillvalue);
                            }
                            break;
                        case "triangle":
                            String[] first_value = sp_command[1].Split(',');
                            String[] second_value = sp_command[2].Split(',');
                            String[] third_value = sp_command[3].Split(',');
                            if ((int.TryParse(first_value[0], out _) && int.TryParse(first_value[1], out _)) && (int.TryParse(second_value[0], out _) && int.TryParse(second_value[1], out _)) && (int.TryParse(third_value[0], out _) && int.TryParse(third_value[1], out _)))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (var.Contains(first_value[0]) && var.Contains(first_value[1]) && var.Contains(second_value[0]) && var.Contains(second_value[1]) && var.Contains(third_value[0]) && var.Contains(third_value[1]))
                            {
                                int element = var.IndexOf(first_value[0]);
                                int element1 = var.IndexOf(first_value[1]);
                                int element2 = var.IndexOf(second_value[0]);
                                int element3 = var.IndexOf(second_value[1]);
                                int element4 = var.IndexOf(third_value[0]);
                                int element5 = var.IndexOf(third_value[1]);
                                String square_command = sp_command[0] + " " + val[element] + "," + val[element1] + " " + val[element2] + "," + val[element3] + " " + val[element4] + "," + val[element5];
                                ddraw dr = new ddraw();
                                dr.draw(j, square_command, fillvalue);
                            }
                            break;
                        case "clear":
                            if (lines[i] == "clear")
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            break;
                        case "drawto":
                            if (int.TryParse(sp_command[1], out _) && int.TryParse(sp_command[2], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (var.Contains(sp_command[1]) && var.Contains(sp_command[2]))
                            {
                                int element = var.IndexOf(sp_command[1]);
                                int element2 = var.IndexOf(sp_command[2]);
                                String drawto = sp_command[0] + " " + val[element] + " " + val[element2];
                                ddraw dr = new ddraw();
                                dr.draw(j, drawto, fillvalue);
                            }
                            break;
                        default: break;
                    }
                }
                // this code explains the conditions for print 
                if (sp_command[0].Equals("print"))
                {
                    Font ft = new Font("Arial", 14);
                    if (sp_command.Length == 2 && var.Contains(sp_command[1]))
                    {
                        int element = var.IndexOf(sp_command[1]);
                        if (element >= 0)
                        {
                            j.DrawString(val[element], ft, Brushes.Purple, new Point(50, 50));
                        }
                    }
                    else if (sp_command.Length == 4 && var.Contains(sp_command[1]) && var.Contains(sp_command[3]) && (sp_command[2] == "+" || sp_command[2] == "-" || sp_command[2] == "*" || sp_command[2] == "/"))
                    {
                        int vable = var.IndexOf(sp_command[1]);
                        int vable2 = var.IndexOf(sp_command[3]);
                        int vl1 = int.Parse(val[vable]);
                        int vl2 = int.Parse(val[vable2]);
                        if (sp_command[2] == "+")
                        {
                            int result = vl1 + vl2;
                            j.DrawString(result.ToString(), ft, Brushes.Purple, new Point(50, 50));
                        }
                        if (sp_command[2] == "-")
                        {
                            int result = vl1 + vl2;
                            j.DrawString(result.ToString(), ft, Brushes.Purple, new Point(50, 50));
                        }
                        if (sp_command[2] == "*")
                        {
                            int result = vl1 + vl2;
                            j.DrawString(result.ToString(), ft, Brushes.Purple, new Point(50, 50));
                        }
                        if (sp_command[2] == "/")
                        {
                            int result = vl1 + vl2;
                            j.DrawString(result.ToString(), ft, Brushes.Purple, new Point(50, 50));
                        }
                    }
                }

                // This part is for increment and decrement.
                if (var.Contains(sp_command[0]) && sp_command[1] == "=" && (sp_command[2]) == sp_command[0])
                {
                    vb_op vp = new vb_op(val, var);
                    int element = var.IndexOf(sp_command[2]);
                    val[element] = vp.n_w(lines[i]);
                }

                // From here all the loops will be started this is the if loop
                if (sp_command[0] == "if")
                {
                    if_condition fc = new if_condition(j, sp_command[2]);
                    String valid = fc.if_statement();
                    if (valid == "false")
                    {
                        Font fr = new Font("Bold", 14);
                        j.DrawString("Not correct 'if' command", fr, Brushes.Purple, new Point(50, 50));
                    }
                    else
                    {
                        if (var.Contains(sp_command[1]) && int.TryParse(sp_command[3], out _))
                        {
                            int element = var.IndexOf(sp_command[1]);
                            if (valid == "==")
                            {
                                if (val[element] == sp_command[3])
                                {
                                    for (int jj = i + 1; jj < lines.Length; jj++)
                                    {
                                        if (lines[jj].Trim() == "endif")
                                        {
                                            i = jj; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[jj];
                                            if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                            ic.comm();
                                        }
                                    }
                                }
                            }
                            else if (valid == ">")
                            {
                                if (int.Parse(val[element]) > int.Parse(sp_command[3]))
                                {
                                    for (int jj = i + 1; jj < lines.Length; jj++)
                                    {
                                        if (lines[jj].Trim() == "endif")
                                        {
                                            i = jj; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[jj];
                                            if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                            ic.comm();
                                        }
                                    }
                                }
                            }
                            else if (valid == "<")
                            {
                                if (int.Parse(val[element]) > int.Parse(sp_command[3]))
                                {
                                    for (int jj = i + 1; jj < lines.Length; jj++)
                                    {
                                        if (lines[jj].Trim() == "endif")
                                        {
                                            i = jj; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[jj];
                                            if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                            ic.comm();
                                        }
                                    }
                                }

                            }
                            else if (valid == "!=")
                            {
                                if (int.Parse(val[element]) > int.Parse(sp_command[3]))
                                {
                                    for (int jj = i + 1; jj < lines.Length; jj++)
                                    {
                                        if (lines[jj].Trim() == "endif")
                                        {
                                            i = jj; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[jj];
                                            if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                            ic.comm();
                                        }
                                    }
                                }
                            }
                            else if (valid == ">=")
                            {
                                if (int.Parse(val[element]) > int.Parse(sp_command[3]))
                                {
                                    for (int jj = i + 1; jj < lines.Length; jj++)
                                    {
                                        if (lines[jj].Trim() == "endif")
                                        {
                                            i = jj; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[jj];
                                            if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                            ic.comm();
                                        }
                                    }
                                }
                            }
                            else if (valid == "<=")
                            {
                                if (int.Parse(val[element]) > int.Parse(sp_command[3]))
                                {
                                    for (int jj = i + 1; jj < lines.Length; jj++)
                                    {
                                        if (lines[jj].Trim() == "endif")
                                        {
                                            i = jj; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[jj];
                                            if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                            ic.comm();
                                        }
                                    }
                                }
                            }
                            else if (var.Contains(sp_command[1]))
                            {
                                String sec_ele_pre = sp_command[3].Trim();
                                if (var.Contains(sec_ele_pre))
                                {
                                    int element_ = var.IndexOf(sp_command[1]);
                                    int second_element = var.IndexOf(sec_ele_pre);
                                    if (valid == "==")
                                    {
                                        if (int.Parse(val[element_]) == int.Parse(val[second_element]))
                                        {
                                            for (int jj = i + 1; jj < lines.Length; jj++)
                                            {
                                                if (lines[jj].Trim() == "endif")
                                                {
                                                    i = jj; break;
                                                }
                                                else
                                                {
                                                    String inside_loop = lines[jj];
                                                    if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                                    ic.comm();
                                                }
                                            }
                                        }
                                    }
                                    if (valid == ">")
                                    {
                                        if (int.Parse(val[element_]) > int.Parse(val[second_element]))
                                        {
                                            for (int jj = i + 1; jj < lines.Length; jj++)
                                            {
                                                if (lines[jj].Trim() == "endif")
                                                {
                                                    i = jj; break;
                                                }
                                                else
                                                {
                                                    String inside_loop = lines[jj];
                                                    if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                                    ic.comm();
                                                }
                                            }
                                        }
                                    }
                                    if (valid == "<")
                                    {
                                        if (int.Parse(val[element_]) > int.Parse(val[second_element]))
                                        {
                                            for (int jj = i + 1; jj < lines.Length; jj++)
                                            {
                                                if (lines[jj].Trim() == "endif")
                                                {
                                                    i = jj; break;
                                                }
                                                else
                                                {
                                                    String inside_loop = lines[jj];
                                                    if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                                    ic.comm();
                                                }
                                            }
                                        }
                                    }
                                    if (valid == "!=")
                                    {
                                        if (int.Parse(val[element_]) > int.Parse(val[second_element]))
                                        {
                                            for (int jj = i + 1; jj < lines.Length; jj++)
                                            {
                                                if (lines[jj].Trim() == "endif")
                                                {
                                                    i = jj; break;
                                                }
                                                else
                                                {
                                                    String inside_loop = lines[jj];
                                                    if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                                    ic.comm();
                                                }
                                            }
                                        }
                                    }
                                    if (valid == ">=")
                                    {
                                        if (int.Parse(val[element_]) > int.Parse(val[second_element]))
                                        {
                                            for (int jj = i + 1; jj < lines.Length; jj++)
                                            {
                                                if (lines[jj].Trim() == "endif")
                                                {
                                                    i = jj; break;
                                                }
                                                else
                                                {
                                                    String inside_loop = lines[jj];
                                                    if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                                    ic.comm();
                                                }
                                            }
                                        }
                                    }
                                    if (valid == "<=")
                                    {
                                        if (int.Parse(val[element_]) > int.Parse(val[second_element]))
                                        {
                                            for (int jj = i + 1; jj < lines.Length; jj++)
                                            {
                                                if (lines[jj].Trim() == "endif")
                                                {
                                                    i = jj; break;
                                                }
                                                else
                                                {
                                                    String inside_loop = lines[jj];
                                                    if_condition_calling ic = new if_condition_calling(inside_loop, j, fillvalue, var, val);
                                                    ic.comm();
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                            else
                            {
                                for (int jj = i + 1; jj < lines.Length; jj++)
                                {
                                    if (lines[jj].Trim() == "endif")
                                    {
                                        i = jj;
                                    }
                                }
                            }
                        }
                    }

                }

                // while loop
                    if (sp_command[0] == "while")
                    { 
                        while_loop wh = new while_loop(sp_command[2]);
                        String condition = wh.validation();
                        if (condition == "false")
                        {
                            Font fr = new Font("Arial", 14);
                            j.DrawString("Invalid while condtion", fr, Brushes.Purple, new Point(50, 50));
                        }
                        if (condition != "false")
                        {
                            if (var.Contains(sp_command[1]))
                            {
                                if (condition == "==")
                                {
                                    int ele_ = var.IndexOf(sp_command[1]);
                                    if (val[ele_] == sp_command[3]) 
                                    {
                                        for (int jj = i + 1; jj < lines.Length; jj++)
                                        {
                                            if (lines[jj].Trim() == "endloop")
                                            {
                                                i = jj;
                                                break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[jj];
                                                while_calling whc = new while_calling(inside_loop, j, fillvalue, var, val);
                                                whc.cmds();
                                            }
                                        }
                                    }
                                }
                                if (condition == ">")
                                {
                                    int ele_ = var.IndexOf(sp_command[1]);
                                    if (int.Parse(val[ele_]) > int.Parse(sp_command[3]))
                                    {
                                        for (int jj = i + 1; jj < lines.Length; jj++)
                                        {
                                            if (lines[jj].Trim() == "endloop")
                                            {
                                                i = jj; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[jj];
                                                while_calling whc = new while_calling(inside_loop, j, fillvalue, var, val);
                                                whc.cmds();
                                            }
                                        }
                                    }
                                }
                                if (condition == "<")
                                {
                                    int ele_ = var.IndexOf(sp_command[1]);
                                    if (int.Parse(val[ele_]) < int.Parse(sp_command[3]))
                                    {
                                        for (int jj = i + 1; jj < lines.Length; jj++)
                                        {
                                            if (lines[jj].Trim() == "endloop")
                                            {
                                                i = jj; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[jj];
                                                while_calling whc = new while_calling(inside_loop, j, fillvalue, var, val);
                                                whc.cmds();
                                            }
                                        }
                                    }
                                }
                                if (condition == "!=")
                                {
                                    int ele_ = var.IndexOf(sp_command[1]);
                                    if (int.Parse(val[ele_]) != int.Parse(sp_command[3]))
                                    {
                                        for (int jj = i + 1; jj < lines.Length; jj++)
                                        {
                                            if (lines[jj].Trim() == "endloop")
                                            {
                                               
                                                i = jj; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[jj];
                                                while_calling whc = new while_calling(inside_loop, j, fillvalue, var, val);
                                                whc.cmds();
                                            }
                                        }
                                    }
                                }
                                if (condition == "<=")
                                {
                                    int ele_ = var.IndexOf(sp_command[1]);
                                    if (int.Parse(val[ele_]) <= int.Parse(sp_command[3]))
                                    {
                                        for (int jj = i + 1; jj < lines.Length; jj++)
                                        {
                                            if (lines[jj].Trim() == "endloop")
                                            {
                                             
                                                i = jj; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[jj];
                                                while_calling whc = new while_calling(inside_loop, j, fillvalue, var, val);
                                                whc.cmds();
                                            }
                                        }
                                    }
                                }
                                if (condition == ">=")
                                {
                                    int ele_ = var.IndexOf(sp_command[1]);
                                    if (int.Parse(val[ele_]) >= int.Parse(sp_command[3]))
                                    {
                                        for (int jj = i + 1; jj < lines.Length; jj++)
                                        {
                                            if (lines[jj].Trim() == "endloop")
                                            {
                                            
                                                i = jj; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[jj];
                                                while_calling whc = new while_calling(inside_loop, j, fillvalue, var, val);
                                                whc.cmds();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int jj = i + 1; jj < lines.Length; jj++)
                                    {
                                        if (lines[jj].Trim() == "endloop")
                                        {
                                            i = jj;
                                        }
                                    }
                                }

                            }
                        }
                    }

                    // this is the last loop which is method loop
                if (sp_command[0] == "method")
                {
                    String[] method_name = sp_command[1].Trim().Split('(', ')');
                    String[] paramters = method_name[1].Trim().Split(',');
                    mthds.Add(method_name[0] + "()");
                    if (paramters == null)
                    {
                        for (int jj = i + 1; jj < lines.Length; jj++)
                        {
                            if (lines[jj].Trim() == "endmethod")
                            {
                                i = jj; break;
                            }
                            else
                            {
                                mthds_cmds.Add(lines[jj]);
                            }
                        }
                    }
                    else
                    {
                        for (int jj = 0; jj < paramters.Length; jj++)
                        {
                            mth_vars.Add(paramters[jj]);
                        }
                        for (int jj = i + 1; jj < lines.Length; jj++)
                        {
                            if (lines[jj].Trim() == "endmethod")
                            {
                                i = jj; break;
                            }
                            else
                            {
                                mthds_cmds.Add(lines[jj]);
                            }
                        }

                    }

                }

                String pattern = @"^([a-zA-Z_]\w*)\(([\w,]+)\)?$";
                Match mm = Regex.Match(sp_command[0].Trim(), pattern);
                if(mm.Success)
                {
                    String[] sp_cll = sp_command[0].Trim().Split('(', ')');
                    String[] pr = sp_cll[1].Split(',');
                    for (int jj = 0; jj < pr.Length; jj++) 
                    {
                        mth_vals.Add(pr[jj]);
                    }
                    for(int jj = 0; jj < mthds_cmds.Count(); jj++)
                    {
                        method_calling_with_paramtres m = new method_calling_with_paramtres(mthds_cmds[jj], j, fillvalue, mth_vars, mth_vals);
                        m.cmds();
                    }
                }
                if (mthds.Contains(sp_command[0]))
                {
                    for (int jj = 0; jj < mthds_cmds.Count(); jj++)
                    {
                        method_calling m = new method_calling(mthds_cmds[jj], j, fillvalue, var, val);
                        m.cmds();
                    }
                }

                
            } // for loop ends here
        }
    }

}






