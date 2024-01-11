using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testScript;

namespace _152120201069_lab5
{
    public partial class NewGame : Form
    {
        private const bool V = false;
        bool turn = true; //true=X false=O
        int turn_count = 0;// 9 oldugunda berabere
        Button[] button;
        public NewGame()
        {
            InitializeComponent();
        }
        public testClass tst = new testClass();
        int score;
       
        private void button_click(object sender, EventArgs e)
        {
            lblscore.Text = "Score: ";
            button = new Button[] {buttonA1,buttonA2,buttonA3,buttonB1,buttonB2,buttonB3,
            buttonC1,buttonC2,buttonC3};
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                b.ForeColor = System.Drawing.Color.Red;
                b.Image = Image.FromFile(@"..\..\resimler\x.png");
            }
            else
            {
                b.Text = "O";
                b.ForeColor = System.Drawing.Color.White;
                b.Image = Image.FromFile(@"..\..\resimler\o.png");
            }
            turn = !turn;
            turn_count++;
            check_for_winner();
            if (!turn)
            {
                computer_move();
            }
        }
        private void computer_move()
        {
            Button move = null;
            move = win_or_block("O"); //win için
            if (move == null)
            {
                move = win_or_block("X"); //block icin
                if (move == null)
                {
                    move = for_corner();
                    if (move == null)
                    {
                        move = for_space();
                    }
                }
            }
            if (move != null)
            {
                move.PerformClick();
            }

        }
        private Button win_or_block(string mark)
        {
            //HORIZONTAL TEST
            if (buttonA1.Text == mark && buttonA2.Text == mark && buttonA3.Text == "") return buttonA3;
            if (buttonA2.Text == mark && buttonA3.Text == mark && buttonA1.Text == "") return buttonA1;
            if (buttonA1.Text == mark && buttonA3.Text == mark && buttonA2.Text == "") return buttonA2;
            if (buttonB1.Text == mark && buttonB2.Text == mark && buttonB3.Text == "") return buttonB3;
            if (buttonB2.Text == mark && buttonB3.Text == mark && buttonB1.Text == "") return buttonB1;
            if (buttonB1.Text == mark && buttonB3.Text == mark && buttonB2.Text == "") return buttonB2;
            if (buttonC1.Text == mark && buttonC2.Text == mark && buttonC3.Text == "") return buttonC3;
            if (buttonC2.Text == mark && buttonC3.Text == mark && buttonC1.Text == "") return buttonC1;
            if (buttonC1.Text == mark && buttonC3.Text == mark && buttonC2.Text == "") return buttonC2;
            //VERTICAL TEST
            if (buttonA1.Text == mark && buttonB1.Text == mark && buttonC1.Text == "") return buttonC1;
            if (buttonB1.Text == mark && buttonC1.Text == mark && buttonA1.Text == "") return buttonA1;
            if (buttonA1.Text == mark && buttonC1.Text == mark && buttonB1.Text == "") return buttonB1;
            if (buttonA2.Text == mark && buttonB2.Text == mark && buttonC2.Text == "") return buttonC2;
            if (buttonB2.Text == mark && buttonC2.Text == mark && buttonA2.Text == "") return buttonA2;
            if (buttonA2.Text == mark && buttonC2.Text == mark && buttonB2.Text == "") return buttonB2;
            if (buttonA3.Text == mark && buttonB3.Text == mark && buttonC3.Text == "") return buttonC3;
            if (buttonB3.Text == mark && buttonC3.Text == mark && buttonA3.Text == "") return buttonA3;
            if (buttonA3.Text == mark && buttonC3.Text == mark && buttonB3.Text == "") return buttonB3;
            //DIAGONAL TEST
            if (buttonA1.Text == mark && buttonB2.Text == mark && buttonC3.Text == "") return buttonC3;
            if (buttonB2.Text == mark && buttonC3.Text == mark && buttonA1.Text == "") return buttonA1;
            if (buttonA1.Text == mark && buttonC3.Text == mark && buttonB2.Text == "") return buttonB2;
            if (buttonA3.Text == mark && buttonB2.Text == mark && buttonC1.Text == "") return buttonC1;
            if (buttonB2.Text == mark && buttonC1.Text == mark && buttonA3.Text == "") return buttonA3;
            if (buttonA3.Text == mark && buttonC1.Text == mark && buttonB2.Text == "") return buttonB2;
            return null;
        }
        private Button for_corner()
        {
            if (buttonA1.Text == "O")
            {
                if (buttonA3.Text == "") return buttonA3;
                if (buttonC3.Text == "") return buttonC3;
                if (buttonC1.Text == "") return buttonC1;
            }
            if (buttonA3.Text == "O")
            {
                if (buttonA1.Text == "") return buttonA1;
                if (buttonC3.Text == "") return buttonC3;
                if (buttonC1.Text == "") return buttonC1;
            }
            if (buttonC3.Text == "O")
            {
                if (buttonA1.Text == "") return buttonA3;
                if (buttonA3.Text == "") return buttonA3;
                if (buttonC1.Text == "") return buttonC1;
            }
            if (buttonC1.Text == "O")
            {
                if (buttonA1.Text == "") return buttonA3;
                if (buttonA3.Text == "") return buttonA3;
                if (buttonC3.Text == "") return buttonC3;
            }
            if (buttonA1.Text == "") return buttonA1;
            if (buttonA3.Text == "") return buttonA3;
            if (buttonC1.Text == "") return buttonC1;
            if (buttonC3.Text == "") return buttonC3;
            return null;
        }
        private Button for_space()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                    {
                        return b;
                    }
                }
            }
            return null;
        }
        private void check_for_winner()
        {
            bool winner = false;
            string who_win = "";
            //horizontal check
            if ((buttonA1.Text == buttonA2.Text) && (buttonA2.Text == buttonA3.Text) && buttonA1.Text != "" &&
                 buttonA2.Text != "" && buttonA3.Text != "")
            {
                winner = true;
            }
            else if ((buttonB1.Text == buttonB2.Text) && (buttonB2.Text == buttonB3.Text) && buttonB1.Text != "" &&
                 buttonB2.Text != "" && buttonB3.Text != "")
            {
                winner = true;
            }
            else if ((buttonC1.Text == buttonC2.Text) && (buttonC2.Text == buttonC3.Text)
                && buttonC1.Text != "" &&
                 buttonC2.Text != "" && buttonC3.Text != "")
            {
                winner = true;
            }
            //vertical check
            if ((buttonA1.Text == buttonB1.Text) && (buttonB1.Text == buttonC1.Text) && buttonA1.Text != "" &&
                 buttonB1.Text != "" && buttonC1.Text != "")
            {
                winner = true;
            }
            else if ((buttonA2.Text == buttonB2.Text) && (buttonB2.Text == buttonC2.Text) && buttonA2.Text != "" &&
                 buttonB2.Text != "" && buttonC2.Text != "")
            {
                winner = true;
            }
            else if ((buttonA3.Text == buttonB3.Text) && (buttonB3.Text == buttonC3.Text)
                && buttonA3.Text != "" && buttonB3.Text != "" && buttonC3.Text != "")
            {
                winner = true;
            }
            //diagonal check
            if ((buttonA1.Text == buttonB2.Text) && (buttonB2.Text == buttonC3.Text) && buttonA1.Text != "" &&
               buttonB2.Text != "" && buttonC3.Text != "")
            {
                winner = true;
            }
            else if ((buttonA3.Text == buttonB2.Text) && (buttonB2.Text == buttonC1.Text) && buttonA3.Text != "" &&
                 buttonB2.Text != "" && buttonC1.Text != "")
            {
                winner = true;
            }//winner kontrolü
            if (winner)
            {
                if (turn)
                {
                    who_win = "o";
                }
                else
                {
                    who_win = "x";
                }
                if (who_win == "x")
                {
                    MessageBox.Show("TEBRIKLER KAZANDIN!");
                }
                if (who_win == "o")
                {
                    MessageBox.Show("MAALESEF KAYBETTİN!");
                }

                turn = true;
                turn_count = 0;


            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("OYUN BERABERE BİTTİ!");
                }


            }
            if (winner == true)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (button[i].Text == "O")
                    {
                        button[i].Text = "o";
                    }
                    if (button[i].Text == "X")
                    {
                        button[i].Text = "x";
                    }

                }
                score = tst.testFuncXoX(txt_studentnumber.Text, who_win, buttonA1.Text, buttonA2.Text,
                  buttonA3.Text, buttonB1.Text, buttonB2.Text, buttonB3.Text,
                  buttonC1.Text, buttonC2.Text, buttonC3.Text);
                lblscore.Text = "Score: " + score;
                turn = true;
                turn_count = 0;

                try
                {
                    for (int i = 0; i < 9; i++)
                    {
                        button[i].Text = "";
                        button[i].Image = null;

                        if (button[i].Text == btnReset.Text)
                        {
                            btnReset.Text = "Reset Game";
                        }
                    }
                }
                catch { }

            }
            if (turn_count == 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (button[i].Text == "O")
                    {
                        button[i].Text = "o";
                    }
                    if (button[i].Text == "X")
                    {
                        button[i].Text = "x";
                    }
                }
                score = tst.testFuncXoX(txt_studentnumber.Text, "draw", buttonA1.Text, buttonA2.Text,
                buttonA3.Text, buttonB1.Text, buttonB2.Text, buttonB3.Text,
                buttonC1.Text, buttonC2.Text, buttonC3.Text);
                lblscore.Text = "Score: " + score;
                turn = true;
                turn_count = 0;
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        button[i].Text = "";
                        button[i].Image = null;

                        if (button[i].Text == btnReset.Text)
                        {
                            btnReset.Text = "Reset Game";
                        }
                    }
                }
                catch { }

            }

        }
      
        private void txt_studentnumber_TextChanged_1(object sender, EventArgs e)
        {
            int a = txt_studentnumber.TextLength;
            if (a < 8)
            {
                lblWarning.Visible = true;
                lblWarning.Text = "Kullanıcı adı en az 8 karakterden oluşmalı!";
                lblWarning.BackColor = Color.Red;
            }
            else
            {
                lblWarning.Visible = false;
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    button[i].Text = "";
                    button[i].Image = null;
                    lblscore.Text = "Score: ";
                    if (button[i].Text == btnReset.Text)
                    {
                        btnReset.Text = "Reset Game";
                    }
                }
            }
            catch { }
        }
    }
}
