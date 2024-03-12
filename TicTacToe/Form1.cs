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

        private char CheckWinner(PictureBox[,] pictureBoxes)
        {
            // Skapa en temporär 3x3 array som representerar det aktuella spelbrädet
            char[,] board = new char[3, 3];

            // Fyll i arrayen baserat på PictureBox-ernas aktuella bilder
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (pictureBoxes[i, j].Image == Properties.Resources.X)
                        board[i, j] = 'X';
                    else if (pictureBoxes[i, j].Image == Properties.Resources.O)
                        board[i, j] = 'O';
                    else
                        board[i, j] = ' '; // Inget markerat i denna ruta
                }
            }

            // Kolla horisontellt och vertikalt
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                    return board[i, 0]; // Det finns en vinnare horisontellt

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                    return board[0, i]; // Det finns en vinnare vertikalt
            }

            // Kolla diagonalt
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
                return board[0, 0]; // Det finns en vinnare diagonalt (från vänster upp till höger ner)

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
                return board[0, 2]; // Det finns en vinnare diagonalt (från höger upp till vänster ner)

            return ' '; // Ingen vinnare ännu
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


        }
    }
}
