using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace flowchartPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            Refresh();
            textLabel.Text = "";

            string text = "Hello World";

            foreach (char c in text)
            {
                textLabel.Text += c;
                Thread.Sleep(50);
                textLabel.Refresh();
            }

            Thread.Sleep(3000);


            this.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);
            
            this.BackColor = Color.Black;
            Refresh();
            Thread.Sleep(400);

            this.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            this.BackColor = Color.Black;
            Refresh();
            Thread.Sleep(400);


            string text2 = "Press the exit button";
            textLabel.Text = "";

            foreach (char c in text2)
            {
                textLabel.Text += c;
                Thread.Sleep(50);
                textLabel.Refresh();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitButton.Visible = false;
            startButton.Visible = false;
            textLabel.Text = "";

            string text = "Good Bye";

            foreach (char c in text)
            {
                textLabel.Text += c;
                Thread.Sleep(50);
                textLabel.Refresh();
            }
            Thread.Sleep(2500);

            Application.Exit();
        }
    }
}
