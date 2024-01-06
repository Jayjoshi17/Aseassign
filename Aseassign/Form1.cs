using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aseassign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            var ase = Graphics.FromImage(pictureBox1.Image);
            ase.Clear(Color.White);

            fill ff = new fill(ase);
            ff.fillvalue = fillBox.Text;

            ddraw d = new ddraw();
            if (textBox2.Text.Equals("reset"))
            {
                reset t = new reset(textBox2.Text, textBox1.Text);
                textBox2.Text = t.do_reset();
                textBox1.Text = t.do_reset();
                fillBox.Text = t.do_reset();
                ase.Clear(Color.White);
            }
            else
            {
                if(textBox1.Text != "")
                {
                    if(textBox2.Text.Equals("run"))
                    {
                    
                        
                            multiline mm = new multiline(textBox1.Text, ase, ff.fillvalue);
                            mm.multiline_call();
                        
                    }
                    else
                    {
                        Font nt = new Font("Verdana", 15);
                        ase.DrawString("Enter run in cmd", nt, Brushes.Red, new Point(50, 50));
                    }
                }
                else
                {
                    d.draw(ase, textBox2.Text, ff.fillvalue);
                }
            }
            //d.draw(ase,textBox2.Text);
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String file = openFileDialog1.FileName;
                var data = File.ReadAllText(file);              
                textBox1.Text = data;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new
                    StreamWriter(saveFileDialog1.FileName);
                file.Write(textBox1.Text);
                file.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            reset rs = new reset(textBox2.Text, textBox1.Text);
            textBox2.Text = rs.do_reset();
            textBox1 .Text = rs.do_reset();
            fillBox.Text = rs.do_reset();
            var graphics = Graphics.FromImage(pictureBox1.Image);
            graphics.Clear(Color.White);
        }

        private void Syntax_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var vg = Graphics.FromImage(pictureBox1.Image);
            vg.Clear(Color.White);
            if(textBox1.Text != "")
            {
                if(textBox2.Text.Equals("run"))
                {
                    String muti = textBox1 .Text;
                    String[] sp_command = muti.Split('\n');
                    int x = 0;
                    foreach (String s in sp_command)
                    {
                        syntaxch sh = new syntaxch(s, vg, x);
                        x += 30;
                    }
                }
            }
            else
            {
                syntaxch sh = new syntaxch(textBox2.Text, vg, 40);
              
            }
        }
    }
}
