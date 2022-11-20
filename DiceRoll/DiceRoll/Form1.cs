using DiceRoll.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {
        static int counter = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (counter < 4000)
            {
                int diceNumber = RandomNumberGenerator();
                switch (diceNumber)
                {
                    case 1:
                        pictureBox2.Image = Resources._1;
                        break;
                    case 2:
                        pictureBox2.Image = Resources._2;
                        break;
                    case 3:
                        pictureBox2.Image = Resources._3;
                        break;
                    case 4:
                        pictureBox2.Image = Resources._4;
                        break;
                    case 5:
                        pictureBox2.Image = Resources._5;
                        break;
                    case 6:
                        pictureBox2.Image = Resources._6;
                        break;

                   
                    default:
                        break;
                }
                counter += 200;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter < 4000)
            {
                int diceNumber = RandomNumberGenerator();
                switch (diceNumber)
                {
                    case 1:
                        pictureBox1.Image = Resources._1;
                        break;
                    case 2:
                        pictureBox1.Image = Resources._2;
                        break;
                    case 3:
                        pictureBox1.Image = Resources._3;
                        break;
                    case 4:
                        pictureBox1.Image = Resources._4;
                        break;
                    case 5:
                        pictureBox1.Image = Resources._5;
                        break;
                    case 6:
                        pictureBox1.Image = Resources._6;
                        break;
                    default:
                        break;
                }
                counter += 200;
            }
        }

        public int RandomNumberGenerator()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = 200;
            timer1.Start();
            timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 200;
            timer1.Start();
            timer2.Start();
        }
    }
}
