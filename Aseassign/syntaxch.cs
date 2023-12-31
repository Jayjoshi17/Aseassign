﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    /// <summary>
    /// This is the exception class of syntax
    /// </summary>
    public class syntaxch
    {
        /// <summary>
        /// Their is a constructor of syntax
        /// </summary>
        /// <param name="comm">It is the object for the command passes by user</param>
        /// <param name="j">This is the object of Graphics to draw shapes</param>
        /// <param name="ypos">It indicates the y-axis</param>
        public int synt(String comm, Graphics j, int ypos)
        {
            int flag = 1;
            String cmdline = comm;
            cmdline = cmdline.ToLower();
            String[] sp_command = cmdline.Split(' ');
            List<string> cmdlist = new List<string>();
            cmdlist.Add("circle");
            cmdlist.Add("rectangle");
            cmdlist.Add("triangle");
            cmdlist.Add("square");
            cmdlist.Add("moveto");
            cmdlist.Add("drawto");
            cmdlist.Add("clear");
            cmdlist.Add("reset");
            cmdlist.Add("if");
            cmdlist.Add("while");
            cmdlist.Add("method");
            cmdlist.Add("endif");
            cmdlist.Add("endloop");
            cmdlist.Add("print");
            if (cmdline.StartsWith("endif"))
            {
                flag = 0;
                if (cmdline.Trim() == "endif")
                {
                    Font fr = new Font("Arial", 14);
                    j.DrawString("The order is", fr, Brushes.Purple, new Point(0, ypos));
                }
            }
            if (cmdline.StartsWith("endmethod"))
            {
                flag = 0;
                if (cmdline.Trim() == "endmethod")
                {
                    Font fr = new Font("Arial", 14);
                    j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
                }
            }
            if (cmdline.StartsWith("endloop"))
            {
                flag = 0;
                if (cmdline.Trim() == "endloop")
                {
                    Font fr = new Font("Arial", 14);
                    j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
                }
            }
            if (cmdline.Contains(" = "))
            {
                flag = 0;

                Font fr = new Font("Arial", 14);
                j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
            }
            if (!cmdlist.Contains(sp_command[0]) && cmdline.Contains('(') && cmdline.Contains(')'))
            {
                flag = 0;
                Font fr = new Font("Arial", 14);
                j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
            }

            // cmdlist.Add("endmethod");
            try
            {
                if (cmdlist.Contains(sp_command[0]))
                {
                    if (cmdline == "")
                    {
                        throw new emptycmdexc(j, ypos);
                    }
                    if (sp_command[0] == "circle")
                    {
                        int ttl_el = sp_command.Count();
                        if (ttl_el == 2 && int.TryParse(sp_command[1], out _))
                        {
                            Font ft = new Font("Arial", 14);
                            j.DrawString("The syntax is proper", ft, Brushes.Purple, new Point(0, ypos));
                        }
                        else
                        {
                            throw new circleexcep(j, ypos);
                        }
                    }
                    if (sp_command[0] == "rectangle" || sp_command[0] == "square")
                    {
                        int ttl_el = sp_command.Count();
                        if (ttl_el == 3 && int.TryParse(sp_command[1], out _) && int.TryParse(sp_command[2], out _))
                        {
                            Font fr = new Font("Arial", 14);
                            j.DrawString("The syntax is proper", fr, Brushes.Purple, new Point(0, ypos));
                        }
                    }
                    else
                    {
                        throw new sqandrecex(j, ypos);
                    }
                }
                if (sp_command[0] == "triangle")
                {
                    int ttl_el = sp_command.Count();
                    if (ttl_el == 4)
                    {
                        Font fr = new Font("Arial", 14);
                        j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));

                    }
                    else
                    {
                        throw new trianglexc(j, ypos);
                    }
                }
                if (sp_command[0].Trim() == "clear")
                {
                    int ttl_ele = sp_command.Count();
                    if (ttl_ele == 1)
                    {
                        Font fr = new Font("Arial", 14);
                        j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
                    }
                    else
                    {
                        throw new cexc(j, ypos);
                    }
                }
                if (sp_command[0].Trim() == "reset")
                {
                    int ttl_el = sp_command.Count();
                    if (ttl_el == 1)
                    {
                        Font fr = new Font("Arial", 14);
                        j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
                    }
                    else
                    {
                        throw new resetex(j, ypos);
                    }
                }
                if (sp_command[0] == "if")
                {
                    int ttl_ele = sp_command.Count();
                    if (ttl_ele == 4)
                    {
                        Font fr = new Font("Arial", 14);
                        j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
                    }
                    else
                    {
                        throw new ifexec(j, ypos);
                    }
                }
                if (sp_command[0] == "while")
                {
                    int ttl_el = sp_command.Count();
                    if (ttl_el == 4)
                    {
                        Font fr = new Font("Arial", 14);
                        j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
                    }
                    else
                    {
                        throw new whileexc(j, ypos);
                    }
                }
                if (sp_command[0] == "method")
                {
                    int ttl_el = sp_command.Count(); ;
                    if (sp_command[1].Contains('(') && sp_command[1].Contains(')'))
                    {
                        if (ttl_el == 2)
                        {
                            Font fr = new Font("Arial", 14);
                            j.DrawString("The synatx is correct", fr, Brushes.Red, new Point(0, ypos));
                        }
                    }
                    else
                    {
                        throw new methdexc(j, ypos);
                    }
                }
                if (sp_command[0] == "print")
                {
                    int ttl_el = sp_command.Count();
                    if (ttl_el == 2)
                    {
                        Font fr = new Font("Arial", 14);
                        j.DrawString("The syntax is correct", fr, Brushes.Purple, new Point(0, ypos));
                    }

                    else
                    {
                        throw new notavalidexc(j, ypos);
                    }
                }

                else if (flag == 1)
                {
                    throw new notavalidexc(j, ypos);
                }
            }
            catch
            {

            }
            return flag;
        }

    }
}



