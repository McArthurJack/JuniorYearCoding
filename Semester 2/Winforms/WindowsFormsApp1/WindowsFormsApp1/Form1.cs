using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Bitmap picture = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Pictures\\" + @"beach.jpg");
        System.Timers.Timer timer1 = new System.Timers.Timer();
        public Form1()
        {
            InitializeComponent();
            PictureBox.Width = picture.Width;
            PictureBox.Height = picture.Height;
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
                timer1.Interval = 1;
                timer1.Elapsed += timer1_Tick;
                timer1.AutoReset = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(Object source, System.Timers.ElapsedEventArgs e)
        {
            Bitmap copy = new Bitmap(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Pictures\\" + @"beach.jpg");
            Bitmap Altered = new Bitmap(copy.Width, copy.Height);
            for (int x = 0; x < copy.Width; x++)
            {
                for (int y = 0; y < copy.Height; y++)
                {
                    Color pixel = copy.GetPixel(x, y);
                    int pixelA = pixel.A;
                    int pixelB = pixel.B;
                    int pixelG = pixel.G;
                    if (pixelA == 255)
                    {
                        pixelA = 0;
                    }
                    if (pixelB == 255)
                    {
                        pixelB = 0;
                    }
                    if (pixelG == 255)
                    {
                        pixelG = 0;
                    }
                    Color temp = Color.FromArgb(pixelA + 1, pixelB + 1, pixelG + 1);
                    Altered.SetPixel(x, y, temp);
                }
            }
            PictureBox.Image = Altered;
        }
    }
}
