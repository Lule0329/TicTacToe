using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string turn = "X";
        bool WinnerX = false;
        bool WinnerO = false;
        int XWins;
        int OWins;

        Image[] images = new Image[] { Properties.Resources.X, Properties.Resources.O, Properties.Resources.bg };

        private void Restart()
        {
            pictureBox1.Image = images[2];
            pictureBox2.Image = images[2];
            pictureBox3.Image = images[2];
            pictureBox4.Image = images[2];
            pictureBox5.Image = images[2];
            pictureBox6.Image = images[2];
            pictureBox7.Image = images[2];
            pictureBox8.Image = images[2];
            pictureBox9.Image = images[2];

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            turn = "X";
            WinnerX = false;
            WinnerO = false;

            Xvinster.Text = "X vinster: " + XWins;
            Ovinster.Text = "O vinster: " + OWins;
        }
        
        private void CheckWin()
        {
            // Kollar om O har vunnit horisontalt
            if ((pictureBox1.Image == images[1] && pictureBox2.Image == images[1] && pictureBox3.Image == images[1]) ||
        (pictureBox4.Image == images[1] && pictureBox5.Image == images[1] && pictureBox6.Image == images[1]) ||
        (pictureBox7.Image == images[1] && pictureBox8.Image == images[1] && pictureBox9.Image == images[1]))
            {
                WinnerO = true;
            }

            // Kollar om X har vunnit horisontalt
            if ((pictureBox1.Image == images[0] && pictureBox2.Image == images[0] && pictureBox3.Image == images[0]) ||
        (pictureBox4.Image == images[0] && pictureBox5.Image == images[0] && pictureBox6.Image == images[0]) ||
        (pictureBox7.Image == images[0] && pictureBox8.Image == images[0] && pictureBox9.Image == images[0]))
            {
                WinnerX = true;
            }

            // Kollar om O har vunnit vertikalt
            if ((pictureBox1.Image == images[1] && pictureBox4.Image == images[1] && pictureBox7.Image == images[1]) ||
        (pictureBox2.Image == images[1] && pictureBox5.Image == images[1] && pictureBox8.Image == images[1]) ||
        (pictureBox3.Image == images[1] && pictureBox6.Image == images[1] && pictureBox9.Image == images[1]))
            {
                WinnerO = true;
            }

            // Kollar om X har vunnit vertikalt
            if ((pictureBox1.Image == images[0] && pictureBox4.Image == images[0] && pictureBox7.Image == images[0]) ||
        (pictureBox2.Image == images[0] && pictureBox5.Image == images[0] && pictureBox8.Image == images[0]) ||
        (pictureBox3.Image == images[0] && pictureBox6.Image == images[0] && pictureBox9.Image == images[0]))
            {
                WinnerX = true;
            }

            // Kollar om O har vunnit diagonalt
            if ((pictureBox1.Image == images[1] && pictureBox5.Image == images[1] && pictureBox9.Image == images[1]) ||
        (pictureBox3.Image == images[1] && pictureBox5.Image == images[1] && pictureBox7.Image == images[1]))
            {
                WinnerO = true;
            }

            // Kollar om X har vunnit diagonalt
            if ((pictureBox1.Image == images[0] && pictureBox5.Image == images[0] && pictureBox9.Image == images[0]) ||
        (pictureBox3.Image == images[0] && pictureBox5.Image == images[0] && pictureBox7.Image == images[0]))
            {
                WinnerX = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Kollar vilken picturebox som man trycker på
            PictureBox clickedPicturebox = sender as PictureBox;

            // sätter antingen "X" eller "O" beroende vems tur det är, disablar pictureboxen om man har tryckt på den
            if (clickedPicturebox != null)
            {
                if (turn == "X")
                {
                    clickedPicturebox.Image = images[0];
                    turn = "O";
                    clickedPicturebox.Enabled = false;
                }
                else if (turn == "O")
                {
                    clickedPicturebox.Image = images[1];
                    turn = "X";
                    clickedPicturebox.Enabled = false;
                }
            }

            CheckWin();
            if (WinnerX == true)
            {
                MessageBox.Show("X Wins");
                XWins += 1;
                Restart();
            }
            else if (WinnerO == true)
            {
                MessageBox.Show("O Wins");
                OWins += 1;
                Restart();
            }
        }
    }
}
