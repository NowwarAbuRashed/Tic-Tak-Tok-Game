using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tak_Tok_Game.Properties;

namespace Tic_Tak_Tok_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Blake = Color.FromArgb(255, 0, 0, 0);
            Pen Pen = new Pen(Blake);

            Pen.Color = Color.White;
            Pen.Width = 5;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(Pen, 650, 150, 350, 150);
            e.Graphics.DrawLine(Pen, 650, 240, 350, 240);
            e.Graphics.DrawLine(Pen, 450,80,450,310);
            e.Graphics.DrawLine(Pen, 550,80,550,310);


        }

        bool CheckWener(PictureBox p1, PictureBox p2, PictureBox p3)
        {
            if (p1.Tag.ToString() == p2.Tag.ToString() && p2.Tag.ToString() == p3.Tag.ToString() && p1.Tag.ToString() != "0" && p2.Tag.ToString() != "0" && p3.Tag.ToString() != "0")
                return true;
            else
                return false;
        }
        void ChingeAllOfChoice()
        {
            picture1.Tag = 1;
            picture2.Tag = 1;
            picture3.Tag=1;
            picture4.Tag = 1;
            picture5.Tag = 1;
            picture6.Tag = 1;
            picture7.Tag = 1;
            picture8.Tag = 1;
            picture9.Tag = 1;

        }
        void ChengBackColor(PictureBox p1,PictureBox p2,PictureBox p3)
        {
            p1.BackColor = Color.AliceBlue;
            p2.BackColor = Color.AliceBlue;
            p3.BackColor = Color.AliceBlue;
            if (lblPlayer.Text == "Player 1")
                lblWinner.Text = "Player 2";
            else
                lblWinner.Text = "Plauer 1";
            lblPlayer.Text = "Game Over";

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChingeAllOfChoice();
        }
        void CheckWhosWener()
        {
            if(CheckWener(picture1,picture2,picture3))
            {
                ChengBackColor(picture1, picture2, picture3);
            }
            else if (CheckWener(picture4, picture5, picture6))
            {
                ChengBackColor(picture4, picture5, picture6);

            }
            else if (CheckWener(picture7, picture8, picture9))
            {
                ChengBackColor(picture7, picture8, picture9);

            }
            else if (CheckWener(picture1, picture4, picture7))
            {
                ChengBackColor(picture1, picture4, picture7);

            }
            else if (CheckWener(picture2, picture5, picture8))
            {
                ChengBackColor(picture2, picture5, picture8);
            }
            else if (CheckWener(picture3, picture6, picture9))
            {
                ChengBackColor(picture3, picture6, picture9);

            }
            else if (CheckWener(picture1, picture5, picture9))
            {
                ChengBackColor(picture1, picture5, picture9);

            }
            else if (CheckWener(picture3, picture5, picture7))
            {
                ChengBackColor(picture3, picture5, picture7);
            }

        }


        void Choice(PictureBox p)
        {
                if(p.Tag.ToString()!="0")
               {
                MessageBox.Show("Wrong Choice","Wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
               }
                if (lblPlayer.Text == "Player 1")
                {
                    p.Image = Resources.X;
                    lblPlayer.Text = "Player 2";
                    p.Tag = 1;
                }
                else
                {
                    p.Image = Resources.O;
                    lblPlayer.Text = "Player 1";
                   p.Tag = 2;
                }
                CheckWhosWener();



        }

        private void picture_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }


        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            picture1.Image = Resources.question_mark_96;
            picture2.Image = Resources.question_mark_96;
            picture3.Image = Resources.question_mark_96;
            picture4.Image = Resources.question_mark_96;
            picture5.Image = Resources.question_mark_96;
            picture6.Image = Resources.question_mark_96;
            picture7.Image = Resources.question_mark_96;
            picture8.Image = Resources.question_mark_96;
            picture9.Image = Resources.question_mark_96;
            picture1.BackColor = Color.Black;
            picture2.BackColor=Color.Black;
            picture3.BackColor=Color.Black;
            picture4.BackColor=Color.Black;
            picture5.BackColor=Color.Black;
            picture6.BackColor=Color.Black;
            picture7.BackColor=Color.Black;
            picture8.BackColor=Color.Black;
            picture9.BackColor=Color.Black;
            picture1.Tag = 0;
            picture2.Tag=0;
            picture3.Tag=0;
            picture4.Tag=0;
            picture5.Tag=0;
            picture6.Tag=0;
            picture7.Tag=0;
            picture8.Tag=0;
            picture9.Tag=0;


            lblPlayer.Text = "Player 1";
            lblWinner.Text = "In Progress";
        }
    }
}
