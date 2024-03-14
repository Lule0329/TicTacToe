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
        int XWins = 0;
        int OWins = 0;

        Image[] images = new Image[] { Properties.Resources.X, Properties.Resources.O, Properties.Resources.bg, Properties.Resources.Xwin, Properties.Resources.Owin, Properties.Resources.Xpreview, Properties.Resources.Opreview };

        private void Restart()
        {
            // sätter alla pictureboxes till samma färg
            pictureBox1.Image = images[2];
            pictureBox2.Image = images[2];
            pictureBox3.Image = images[2];
            pictureBox4.Image = images[2];
            pictureBox5.Image = images[2];
            pictureBox6.Image = images[2];
            pictureBox7.Image = images[2];
            pictureBox8.Image = images[2];
            pictureBox9.Image = images[2];

            // Enablar alla pictureboxes
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            // återställer variabler och booleans
            turn = "X";
            WinnerX = false;
            WinnerO = false;

            // Lägger till ett poäng till den som vinner
            label1.Text = $"X vinster: " + XWins;
            label2.Text = "O vinster: " + OWins;
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

        private void setGreen()
        {
            // Kollar vilka rutor ska bli gröna första raden
            if (pictureBox1.Image == images[0] && pictureBox2.Image == images[0] && pictureBox3.Image == images[0])
            {
                pictureBox1.Image = images[3];
                pictureBox2.Image = images[3];
                pictureBox3.Image = images[3];
            }

            if (pictureBox1.Image == images[1] && pictureBox2.Image == images[1] && pictureBox3.Image == images[1])
            {
                pictureBox1.Image = images[4];
                pictureBox2.Image = images[4];
                pictureBox3.Image = images[4];
            }

            // Kollar andra raden
            if (pictureBox4.Image == images[0] && pictureBox5.Image == images[0] && pictureBox6.Image == images[0])
            {
                pictureBox4.Image = images[3];
                pictureBox5.Image = images[3];
                pictureBox6.Image = images[3];
            }

            if (pictureBox4.Image == images[1] && pictureBox5.Image == images[1] && pictureBox6.Image == images[1])
            {
                pictureBox4.Image = images[4];
                pictureBox5.Image = images[4];
                pictureBox6.Image = images[4];
            }

            // Kollar tredje raden
            if (pictureBox7.Image == images[0] && pictureBox8.Image == images[0] && pictureBox9.Image == images[0])
            {
                pictureBox7.Image = images[3];
                pictureBox8.Image = images[3];
                pictureBox9.Image = images[3];
            }

            if (pictureBox7.Image == images[1] && pictureBox8.Image == images[1] && pictureBox9.Image == images[1])
            {
                pictureBox7.Image = images[4];
                pictureBox8.Image = images[4];
                pictureBox9.Image = images[4];
            }

            // Kollar första raden vertikalt
            if (pictureBox1.Image == images[0] && pictureBox4.Image == images[0] && pictureBox7.Image == images[0])
            {
                pictureBox1.Image = images[3];
                pictureBox4.Image = images[3];
                pictureBox7.Image = images[3];
            }

            if (pictureBox1.Image == images[1] && pictureBox4.Image == images[1] && pictureBox7.Image == images[1])
            {
                pictureBox1.Image = images[4];
                pictureBox4.Image = images[4];
                pictureBox7.Image = images[4];
            }

            // Kollar andra raden vertikalt
            if (pictureBox2.Image == images[0] && pictureBox5.Image == images[0] && pictureBox8.Image == images[0])
            {
                pictureBox2.Image = images[3];
                pictureBox5.Image = images[3];
                pictureBox8.Image = images[3];
            }

            if (pictureBox2.Image == images[1] && pictureBox5.Image == images[1] && pictureBox8.Image == images[1])
            {
                pictureBox2.Image = images[4];
                pictureBox5.Image = images[4];
                pictureBox8.Image = images[4];
            }

            // Kollar tredje raden vertikalt
            if (pictureBox3.Image == images[0] && pictureBox6.Image == images[0] && pictureBox9.Image == images[0])
            {
                pictureBox3.Image = images[3];
                pictureBox6.Image = images[3];
                pictureBox9.Image = images[3];
            }

            if (pictureBox3.Image == images[1] && pictureBox6.Image == images[1] && pictureBox9.Image == images[1])
            {
                pictureBox3.Image = images[4];
                pictureBox6.Image = images[4];
                pictureBox9.Image = images[4];
            }

            // Kollar diagonalt
            if (pictureBox1.Image == images[0] && pictureBox5.Image == images[0] && pictureBox9.Image == images[0])
            {
                pictureBox1.Image = images[3];
                pictureBox5.Image = images[3];
                pictureBox9.Image = images[3];
            }

            if (pictureBox1.Image == images[1] && pictureBox5.Image == images[1] && pictureBox9.Image == images[1])
            {
                pictureBox1.Image = images[4];
                pictureBox5.Image = images[4];
                pictureBox9.Image = images[4];
            }

            // Kollar andra diagonalen
            if (pictureBox3.Image == images[0] && pictureBox5.Image == images[0] && pictureBox7.Image == images[0])
            {
                pictureBox3.Image = images[3];
                pictureBox5.Image = images[3];
                pictureBox7.Image = images[3];
            }

            if (pictureBox3.Image == images[1] && pictureBox5.Image == images[1] && pictureBox7.Image == images[1])
            {
                pictureBox3.Image = images[4];
                pictureBox5.Image = images[4];
                pictureBox7.Image = images[4];
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

            CheckWin(); // kollar om nån vinner
            if (WinnerX == true) // om X vinner så gör den det här \/
            {
                setGreen();
                MessageBox.Show("X Wins");
                XWins += 1;
                Restart();
            }
            else if (WinnerO == true) // om O vinner gör den det här \/
            {
                setGreen();
                MessageBox.Show("O Wins");
                OWins += 1;
                Restart();
            }
            else if (pictureBox1.Image != images[2] && pictureBox2.Image != images[2] && pictureBox3.Image != images[2] && pictureBox4.Image != images[2]
                && pictureBox5.Image != images[2] && pictureBox6.Image != images[2] && pictureBox7.Image != images[2] && pictureBox8.Image != images[2]
                && pictureBox9.Image != images[2] && WinnerO == false && WinnerX == false)
            {
                MessageBox.Show("Draw!");
                Restart();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Gör en preview om hur spelplanen kommer se ut om man hoverar över en ruta.
            PictureBox pictureBox = sender as PictureBox;
            
            // Kollar om rutan är tom
            if (pictureBox.Image == images[2]) 
            {
                // preview-ar kryss eller cirkel beroende på vems tur det är
                if (turn == "X")
                {
                    pictureBox.Image = images[5];
                }
                else if (turn == "O")
                {
                    pictureBox.Image = images[6];
                }
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            
            // Ser till så att den inte byter redan kryssade rutor till bakgrund
            if (pictureBox.Enabled == true)
            {
                pictureBox.Image = images[2];
            }
        }
    }
}
