using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2266
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();
       

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Location.Y < 195)
            {
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Interval = 1;
                timer.Start();
                timer.Tick += new EventHandler(Timer_Tick2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (pictureBox1.Location.Y < 93)
            {
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick2);
                //timer.Tick -= new EventHandler(Timer_Tick);
                timer.Interval = 1;
                timer.Start();
                timer.Tick += new EventHandler(Timer_Tick3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (pictureBox1.Location.Y > 93)
            {
                 timer.Tick -= new EventHandler(Timer_Tick5);
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Interval = 1;
                timer.Start();
                timer.Tick += new EventHandler(Timer_Tick4);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            

            if (pictureBox1.Location.Y > 0)
            {
                timer.Tick -= new EventHandler(Timer_Tick4);
                timer.Tick -= new EventHandler(Timer_Tick3);
                timer.Tick -= new EventHandler(Timer_Tick2);
                timer.Interval = 1;
                timer.Start();
                timer.Tick += new EventHandler(Timer_Tick5);
            }
        }

        void Timer_Tick2(object Sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 195)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            }
        }
        void Timer_Tick3(object Sender, EventArgs e)
        {
            if (pictureBox1.Location.Y < 93)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            }
        }
        void Timer_Tick4(object Sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 93)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            }
        }
        void Timer_Tick5(object Sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            }
        }
        
    }
}
