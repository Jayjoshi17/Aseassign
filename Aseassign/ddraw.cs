﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class ddraw
    {
        private int xpos = 0;
        private int ypos = 0;
        public void draw(Graphics j, String cmd)
        {
            String fillvalue = "on";
            Pen pen = new Pen(Color.Purple);
            Brush brush = new SolidBrush(Color.Red);
            String command = cmd;
            command = command.ToLower();
            String[] split_command = command.Split(' ');

            List<string> commandlist = new List<string>();
            commandlist.Add("circle");
            commandlist.Add("Rectangle");
            commandlist.Add("triangle");
            commandlist.Add("square");
            commandlist.Add("drawto");
            commandlist.Add("clear");
            commandlist.Add("reset");
            if (commandlist.Contains(split_command[0]))
            {
                /*
                if (split_command[0] == "fill")
                {
                     if (split_command[1] == "on")
                {
                    fillEnable = true;
                }
                else
                {
                    fillEnable = false;
                }
                }*/
                switch (split_command[0])
                {
                    case "circle":
                        Circle r = new Circle(int.Parse(split_command[1]));
                        if (fillvalue == "on")
                        {
                            r.drawfill(j, brush, xpos, ypos);
                        }
                        else
                        {
                            r.draw(j, pen, xpos, ypos);
                        }
                        break;
                    case "rectangle":
                        Rectangle rect = new Rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));
                        if (fillvalue == "on")
                        {
                            rect.drawfill(j, brush, xpos, ypos);
                        }
                        else
                        {
                            rect.draw(j, pen, xpos, ypos);
                        }
                        break;

                }
            }
        }
    }
}

           