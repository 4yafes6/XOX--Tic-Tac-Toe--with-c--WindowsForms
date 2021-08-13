using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class xoxGame : Form
    {
        public xoxGame()
        {
            InitializeComponent();
        }
        //necessary variables are defined
        string player = "";
        int counter = 0;
        int play1score = 0;
        int play2score = 0;

        /*
        * this function allows each click to pass to the other player
        */
        private void changePlayer()
        {
            if (counter % 2 == 0)
            {
                player = "O";
            }
            else
            {
                player = "X";
            }
            counter += 1;
            XO.Text = player;
        }


        /*
        * this function determines the winner 
        * and closes all the boxes and ends the game
        * then announces the winner and adds a point to it
        */
        public void Winner()
        {
            if ((button1.Text == "X" & button2.Text == "X" & button3.Text == "X") ||
                (button1.Text == "X" & button4.Text == "X" & button7.Text == "X") ||
                (button1.Text == "X" & button5.Text == "X" & button9.Text == "X") ||
                (button7.Text == "X" & button5.Text == "X" & button3.Text == "X") ||
                (button7.Text == "X" & button8.Text == "X" & button9.Text == "X") ||
                (button9.Text == "X" & button6.Text == "X" & button3.Text == "X") ||
                (button2.Text == "X" & button5.Text == "X" & button8.Text == "X") ||
                (button4.Text == "X" & button5.Text == "X" & button6.Text == "X"))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                MessageBox.Show("X Won", "Tour is Over");
                play1score++;
                play1_score.Text = play1score.ToString();
            }
            if ((button1.Text == "O" & button2.Text == "O" & button3.Text == "O") ||
                (button1.Text == "O" & button4.Text == "O" & button7.Text == "O") ||
                (button1.Text == "O" & button5.Text == "O" & button9.Text == "O") ||
                (button7.Text == "O" & button5.Text == "O" & button3.Text == "O") ||
                (button7.Text == "O" & button8.Text == "O" & button9.Text == "O") ||
                (button9.Text == "O" & button6.Text == "O" & button3.Text == "O") ||
                (button2.Text == "O" & button5.Text == "O" & button8.Text == "O") ||
                (button4.Text == "O" & button5.Text == "O" & button6.Text == "O"))
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                MessageBox.Show("O Won", "Tour is Over");
                play2score++;
                play2_score.Text = play2score.ToString();
            }

        }
        private void xoxGame_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Text = XO.Text;
            changePlayer();
            button1.Enabled = false;
            Winner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = XO.Text;
            changePlayer();
            button2.Enabled = false;
            Winner();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = XO.Text;
            changePlayer();
            button3.Enabled = false;
            Winner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = XO.Text;
            changePlayer();
            button4.Enabled = false;
            Winner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = XO.Text;
            changePlayer();
            button5.Enabled = false;
            Winner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = XO.Text;
            changePlayer();
            button6.Enabled = false;
            Winner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = XO.Text;
            changePlayer();
            button7.Enabled = false;
            Winner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = XO.Text;
            changePlayer();
            button8.Enabled = false;
            Winner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = XO.Text;
            changePlayer();
            button9.Enabled = false;
            Winner();
        }

        private void NextRound_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void ResetScore_Click(object sender, EventArgs e)
        {
            play1score = 0;
            play2score = 0;
            play1_score.Text = "0";
            play2_score.Text = "0";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            İnfo inf = new İnfo();
            inf.ShowDialog();
        }
    }
}
