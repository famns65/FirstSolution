using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberGUI
{
    public partial class Form1 : Form
    {
        Random randomGenerator = new Random();
        int value;
        public Form1()
        {
            InitializeComponent();
            value = randomGenerator.Next(1, 100);
        }

        private void Guessbutton_Click(object sender, EventArgs e)
        {


            int counter = int.Parse(counterLable.Text);

            //if (counter==0)
            //{
            //    //MessageBox.Show("Game Over!");
            //    return;
            //}

            int guess = int.Parse(numberTextBox.Text);
            if (guess > value)
            {
                Resultlable.Text = "Enter Lower Number";
            }
            else if (guess < value)
            {
                Resultlable.Text = "Enter Higher Number";
            }
            else
            {

                MessageBox.Show("You Won!","Start Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            numberTextBox.Text = "";

            if (guess == value)
            {
                Resultlable.Text = "";
                counter = 0;
                counterLable.Text = "7";
            }
            else
            {
                counterLable.Text = (counter - 1).ToString();
            }
            if (counterLable.Text == "0")
            {

                MessageBox.Show("Game Over!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Resultlable.Text = "";
                counter = 0;
                counterLable.Text = "7";
            }

        }

    }
}
