using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sfarsit.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            inamic(gamespeed);
            ghinion();
            coins(gamespeed);
            coinscollection();
        }

        int collectedcoins = 0;
        Random nou = new Random();
        int x, y;
        void inamic(int speed)
        {
            if (inamic1.Top >= 500)
            {
                x = nou.Next(0, 200);
                inamic1.Location = new Point(x, 0);
            }
            else { inamic1.Top += speed; }

            if (inamic2.Top >= 500)
            {
                x = nou.Next(0, 200);
                inamic2.Location = new Point(x, 0);
            }
            else { inamic2.Top += speed; }

            if (inamic3.Top >= 500)
            {
                x = nou.Next(0, 200);
                inamic3.Location = new Point(x, 0);
            }
            else { inamic3.Top += speed; }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = nou.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = nou.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = nou.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }
        }
        void ghinion()
        {
            if (masina.Bounds.IntersectsWith(inamic1.Bounds))
            {
                timer1.Enabled = false;
                sfarsit.Visible = true;
            }

            if (masina.Bounds.IntersectsWith(inamic2.Bounds))
            {
                timer1.Enabled = false;
                sfarsit.Visible = true;
            }

            if (masina.Bounds.IntersectsWith(inamic3.Bounds))
            {
                timer1.Enabled = false;
                sfarsit.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }


        }

        void coinscollection()
        {
            if (masina.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoins++;
                label1.Text = "coins = " + collectedcoins.ToString();
                x = nou.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }

            if (masina.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoins++;
                label1.Text = "coins = " + collectedcoins.ToString();
                x = nou.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }

            if (masina.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoins++;
                label1.Text = "coins = " + collectedcoins.ToString();
                x = nou.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (masina.Left > 0)
                    masina.Left += -8;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (masina.Right < 300)
                    masina.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
        }
    }
}
