using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            //DoxSomeone.MouseEnter += (o, e) => ChangeColor(Color.Red, Color.Black);
            //DoxSomeone.MouseLeave += (o, e) => ChangeColor(Color.White, Color.Blue);
        }

        public void ChangeColor(Color c, Color b)
        {
            DoxSomeone.ForeColor = c;
            DoxSomeone.BackColor = b;
        }

        private void DoxSomeone_Click(object sender, EventArgs e)
        {
            if (FailSafe.Checked && DateTimePicker.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(PictureBox.Width, PictureBox.Height);
                Random rand = new Random();

                for (int x = 0; x < PictureBox.Width; x++)
                {
                    for (int y = 0; y < PictureBox.Height; y++)
                    {
                        b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Red : Color.Blue);
                        //b.SetPixel(x, y, Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                    }
                }
                PictureBox.Image = b;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Quit Program")
            {
                Environment.Exit(0);
            }
            else if (textBox1.Text == "Start")
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(Object Sender, EventArgs e)
        {
            
            Bitmap picture = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Pictures\\" + @"beach.jpg");
            Bitmap copy = new Bitmap(picture.Width, picture.Height);
            PictureBox.Width = picture.Width;
            PictureBox.Height = picture.Height;
            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    Color pixel = picture.GetPixel(x, y);
                    pixel = Color.FromArgb(pixel.ToArgb() ^ 0xffffff);
                    copy.SetPixel(x, y, pixel);
                }
            }
            PictureBox.Image = copy;
        }
    }
}
