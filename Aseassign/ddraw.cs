using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseassign
{
    public class ddraw
    {
        public void draw(Graphics j, string command)
        {
            Pen pen = new Pen(Color.Purple, 3);
            if (command == "circle")
            {
                Circle circle = new Circle(30);
                circle.draw(j, pen);
            }
            else if (command == "square" || command == "rectangle")
            {
                Rectangle rect = new Rectangle(50, 100);
                rect.draw(j, pen);
            }
        }
    }
}
