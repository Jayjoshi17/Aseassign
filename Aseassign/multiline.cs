using System;
using Aseassign;
using Aseassign.Properties;
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
        List<string> var = new List<string>();
        List<string> val = new List<string>();
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


                if (sp_command.Contains("="))
                {
                    val.Add(sp_command[2]);
                    var.Add(sp_command[0]);
                }
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
                            else if(var.Contains(sp_command[1]))
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

                if (sp_command[0].Equals("print"))
                {
                             Font ft = new Font("Arial", 14);
                    if (sp_command.Length == 2 && var.Contains(sp_command[1]))
                    {
                        int element = var.IndexOf(sp_command[1]);
                        if(element >= 0)
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
                if (var.Contains(sp_command[0]) && sp_command[1] == "=" && (sp_command[2]) == sp_command[0])
              {
                vb_op vp = new vb_op(val, var);
                int element = var.IndexOf(sp_command[2]);
                val[element] = vp.n_w(lines[i]);
            }

            }

        }

    }
}



