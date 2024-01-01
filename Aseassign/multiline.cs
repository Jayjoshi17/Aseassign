using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Aseassign
{
    public class multiline
    {
        String cmds;
        String fillvalue;
        List<string> vrs = new List<string>();
        List<string> vales = new List<string>();
        List<string> mth_vars = new List<string>();
        List<string> mthds = new List<string>();
        List<string> mthds_cmds = new List<string>();
        Graphics j;
        public multiline(String cmds, Graphics j, String fillvalue)
        {
            this.cmds = cmds;
            this.j = j;
            this.fillvalue = fillvalue;
        }
        public void multiline_call()
        {
            if (j is null)
            {
                throw new ArgumentNullException(nameof(j));
            }
            List<string> commandlist = new List<string>();
            commandlist.Add("circle");
            commandlist.Add("rectangle");
            commandlist.Add("triangle");
            commandlist.Add("square");
            commandlist.Add("drawto");
            commandlist.Add("clear");
            String[] lines = cmds.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                String[] split_command = lines[i].Split(' ');


                if (commandlist.Contains(split_command[0]))
                {
                    split_command[0].ToLower();
                    switch (split_command[0])
                    {
                        case "circle":
                            if (int.TryParse(split_command[1], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, cmds, fillvalue);
                            }
                            else if(vrs.Contains(split_command[1]))
                            {
                                Font f = new Font("Arial", 14);
                                j.DrawString("madarchod", f, Brushes.Red, new Point(50, 50));
                               /* int element = vrs.IndexOf(split_command[1]);
                                String circle_command = split_command[0] + " " + vales[element];
                                ddraw dr = new ddraw();
                                dr.draw(j, "circle 90", fillvalue);*/
                            }
                            break;
                        case "rectangle":
                            if (int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (vrs.Contains(split_command[1]) && vrs.Contains(split_command[2]))
                            {
                                int element = vrs.IndexOf(split_command[1]);
                                int element2 = vrs.IndexOf(split_command[2]);
                                String rect_command = split_command[0] + " " + vales[element] + " " + vales[element2];
                                ddraw dr = new ddraw();
                                dr.draw(j, rect_command, fillvalue);
                            }
                            break;
                        case "square":
                            if (int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (vrs.Contains(split_command[1]) && vrs.Contains(split_command[2]))
                            {
                                int element = vrs.IndexOf(split_command[1]);
                                int element2 = vrs.IndexOf(split_command[2]);
                                String square_command = split_command[0] + " " + vales[element] + " " + vales[element2];
                                ddraw dr = new ddraw();
                                dr.draw(j, square_command, fillvalue);
                            }
                            break;
                        case "triangle":
                            String[] first_value = split_command[1].Split(',');
                            String[] second_value = split_command[2].Split(',');
                            String[] third_value = split_command[3].Split(',');
                            if ((int.TryParse(first_value[0], out _) && int.TryParse(first_value[1], out _)) && (int.TryParse(second_value[0], out _) && int.TryParse(second_value[1], out _)) && (int.TryParse(third_value[0], out _) && int.TryParse(third_value[1], out _)))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (vrs.Contains(first_value[0]) && vrs.Contains(first_value[1]) && vrs.Contains(second_value[0]) && vrs.Contains(second_value[1]) && vrs.Contains(third_value[0]) && vrs.Contains(third_value[1]))
                            {
                                int element = vrs.IndexOf(first_value[0]);
                                int element1 = vrs.IndexOf(first_value[1]);
                                int element2 = vrs.IndexOf(second_value[0]);
                                int element3 = vrs.IndexOf(second_value[1]);
                                int element4 = vrs.IndexOf(third_value[0]);
                                int element5 = vrs.IndexOf(third_value[1]);
                                String square_command = split_command[0] + " " + vales[element] + "," + vales[element1] + " " + vales[element2] + "," + vales[element3] + " " + vales[element4] + "," + vales[element5];
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
                            if (int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                            {
                                ddraw dr = new ddraw();
                                dr.draw(j, lines[i], fillvalue);
                            }
                            else if (vrs.Contains(split_command[1]) && vrs.Contains(split_command[2]))
                            {
                                int element = vrs.IndexOf(split_command[1]);
                                int element2 = vrs.IndexOf(split_command[2]);
                                String drawto = split_command[0] + " " + vales[element] + " " + vales[element2];
                                ddraw dr = new ddraw();
                                dr.draw(j, drawto, fillvalue);
                            }
                            break;
                        default: break;
                    }
                }


                if (split_command.Contains("="))
                {
                    vrs.Add(split_command[0].Trim());
                    vales.Add(split_command[2].Trim());
                   
                }
            }

        }

    }
}



