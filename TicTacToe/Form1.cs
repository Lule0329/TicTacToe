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
        string Winner;

        private void CheckWin()
        {
            // Kollar om X vinner horizontalt
            if (pictureBox1.Image == Properties.Resources.X && pictureBox2.Image == Properties.Resources.X && pictureBox3.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else if (pictureBox4.Image == Properties.Resources.X && pictureBox5.Image == Properties.Resources.X && pictureBox6.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else if (pictureBox7.Image == Properties.Resources.X && pictureBox8.Image == Properties.Resources.X && pictureBox9.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else
            {
                Winner = " ";
            }

            // Kollar om O vinner horizontalt
            if (pictureBox1.Image == Properties.Resources.O && pictureBox2.Image == Properties.Resources.O && pictureBox3.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else if (pictureBox4.Image == Properties.Resources.O && pictureBox5.Image == Properties.Resources.O && pictureBox6.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else if (pictureBox7.Image == Properties.Resources.O && pictureBox8.Image == Properties.Resources.O && pictureBox9.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else
            {
                Winner = " ";
            }

            // Kollar om X vinner Vertikalt
            if (pictureBox1.Image == Properties.Resources.X && pictureBox4.Image == Properties.Resources.X && pictureBox7.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else if (pictureBox2.Image == Properties.Resources.X && pictureBox5.Image == Properties.Resources.X && pictureBox8.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else if (pictureBox3.Image == Properties.Resources.X && pictureBox6.Image == Properties.Resources.X && pictureBox9.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else
            {
                Winner = " ";
            }

            // Kollar om O vinner vertikalt
            if (pictureBox1.Image == Properties.Resources.O && pictureBox4.Image == Properties.Resources.O && pictureBox7.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else if (pictureBox2.Image == Properties.Resources.O && pictureBox5.Image == Properties.Resources.O && pictureBox8.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else if (pictureBox3.Image == Properties.Resources.O && pictureBox6.Image == Properties.Resources.O && pictureBox9.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else
            {
                Winner = " ";
            }

            // Kollar om X vinner diagonalt
            if (pictureBox1.Image == Properties.Resources.X && pictureBox5.Image == Properties.Resources.X && pictureBox9.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else if (pictureBox3.Image == Properties.Resources.X && pictureBox5.Image == Properties.Resources.X && pictureBox7.Image == Properties.Resources.X)
            {
                Winner = "X";
            }
            else 
            { 
                Winner = " "; 
            }

            // Kollar om O vinner diagonalt
            if (pictureBox1.Image == Properties.Resources.O && pictureBox5.Image == Properties.Resources.O && pictureBox9.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else if (pictureBox3.Image == Properties.Resources.O && pictureBox5.Image == Properties.Resources.O && pictureBox7.Image == Properties.Resources.O)
            {
                Winner = "O";
            }
            else
            {
                Winner = " ";
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
                    clickedPicturebox.Image = Properties.Resources.X;
                    turn = "O";
                    clickedPicturebox.Enabled = false;
                }
                else if (turn == "O")
                {
                    clickedPicturebox.Image = Properties.Resources.O;
                    turn = "X";
                    clickedPicturebox.Enabled = false;
                }
            }

            CheckWin();
            if (Winner == "X")
            {
                MessageBox.Show("X Wins");
            }
            else if (Winner == "O")
            {
                MessageBox.Show("O Wins");
            }
        }
    }
}
