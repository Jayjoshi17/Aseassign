using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class syntaxch
    {
        public syntaxch(String comm, Graphics j, int ypos)
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

            cmdlist.Add("endmethod");
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
                else
                {
                    throw new notavalidexc(j, ypos);
                }
            }
            catch
            {

            }

        }

    }
}



