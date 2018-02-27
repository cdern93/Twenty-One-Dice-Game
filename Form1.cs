using System;
using System.Windows.Forms;

// Caroline Dern
// Final Project

namespace Twenty_One
{
    public partial class Form1 : Form
    {
        RollDice roll = new RollDice();
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int currTot = 0;

            num1 = roll.getNum1();
            num2 = roll.getNum2();

            yourNum1Box.Text = num1.ToString();
            yourNum2Box.Text = num2.ToString();

            currTot = num1 + num2;
            if (currTot == 21)
            {
                MessageBox.Show("Congrats! You won!");
            }
            else
            {
                currTotBox.Text = currTot.ToString();
            }
            
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = 0;
                int num2 = 0;
                int currTot = 0;
                int oldTot = int.Parse(currTotBox.Text);
                yourNum1Box.Text = "";
                yourNum2Box.Text = "";

                if (oldTot < 15)
                {
                    num1 = roll.getNum1();
                    num2 = roll.getNum2();

                    yourNum1Box.Text = num1.ToString();
                    yourNum2Box.Text = num2.ToString();

                    currTot = oldTot + num1 + num2;
                    currTotBox.Text = currTot.ToString();
                }
                else if (oldTot >= 15)
                {
                    num1 = roll.getNum1();
                    yourNum1Box.Text = num1.ToString();
                    currTot = oldTot + num1;
                    currTotBox.Text = currTot.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Please press Start to begin a new game.");
            }

        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            int total = 0;
            total = int.Parse(currTotBox.Text);

            if (total == 21)
            {
                MessageBox.Show("Congrats! You won!");
            }
            else
            {
                MessageBox.Show("Sorry, you've lost.");
            }
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            yourNum1Box.Text = "";
            yourNum2Box.Text = "";
            currTotBox.Text = "";
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
