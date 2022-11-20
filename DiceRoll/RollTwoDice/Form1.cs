using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RollTwoDice
{
    public partial class Form1 : Form
    {

        static int counter = 200;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = 200;
            if (Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) >= 15)
            {
                timer2.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter < 4000)
            {
                label1.Text = RandomNumberGenerator().ToString();
                counter += 200;
            }
        }

        public int RandomNumberGenerator()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (counter < 4000)
            {
                label2.Text = RandomNumberGenerator().ToString();
                counter += 200;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 200;
            timer1.Start();
            timer2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
