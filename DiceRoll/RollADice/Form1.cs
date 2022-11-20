using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RollADice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int counter = 200;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter < 4000)
            {
                label1.Text = RandomNumberGenerator().ToString();
                counter += 200;
            }
            else
            {
                timer1.Stop();
                if (Convert.ToInt32(label1.Text) == 21)
                {
                    MessageBox.Show("You Won!");
                }
                else
                {
                    MessageBox.Show("You Lost!");
                }
            }
        }

        public int RandomNumberGenerator()
        {
            Random random = new Random();
            return random.Next(15, 25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 200;
            timer1.Start();
        }
    }
}
