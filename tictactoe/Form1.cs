namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x turn, false = o turn
        bool against_computer = false;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Computer Software Design - Tic Tac Toe Project by Lactao & Muldera");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();

            if ((!turn) && (against_computer))
            {
                computer_make_move();
            }
        }

        private void computer_make_move()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if

            move.PerformClick();
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (b1.Text == "O")
            {
                if (b3.Text == "")
                    return b3;
                if (b9.Text == "")
                    return b9;
                if (b7.Text == "")
                    return b7;
            }

            if (b3.Text == "O")
            {
                if (b1.Text == "")
                    return b1;
                if (b9.Text == "")
                    return b9;
                if (b7.Text == "")
                    return b7;
            }

            if (b9.Text == "O")
            {
                if (b1.Text == "")
                    return b3;
                if (b3.Text == "")
                    return b3;
                if (b7.Text == "")
                    return b7;
            }

            if (b7.Text == "O")
            {
                if (b1.Text == "")
                    return b3;
                if (b3.Text == "")
                    return b3;
                if (b9.Text == "")
                    return b9;
            }

            if (b1.Text == "")
                return b1;
            if (b3.Text == "")
                return b3;
            if (b7.Text == "")
                return b7;
            if (b9.Text == "")
                return b9;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((b1.Text == mark) && (b2.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b2.Text == mark) && (b3.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b3.Text == mark) && (b2.Text == ""))
                return b2;

            if ((b4.Text == mark) && (b5.Text == mark) && (b6.Text == ""))
                return b6;
            if ((b5.Text == mark) && (b6.Text == mark) && (b4.Text == ""))
                return b4;
            if ((b4.Text == mark) && (b6.Text == mark) && (b5.Text == ""))
                return b5;

            if ((b7.Text == mark) && (b8.Text == mark) && (b9.Text == ""))
                return b9;
            if ((b8.Text == mark) && (b9.Text == mark) && (b7.Text == ""))
                return b7;
            if ((b7.Text == mark) && (b9.Text == mark) && (b8.Text == ""))
                return b8;

            //VERTICAL TESTS
            if ((b1.Text == mark) && (b4.Text == mark) && (b7.Text == ""))
                return b7;
            if ((b4.Text == mark) && (b7.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b7.Text == mark) && (b4.Text == ""))
                return b4;

            if ((b2.Text == mark) && (b5.Text == mark) && (b8.Text == ""))
                return b8;
            if ((b5.Text == mark) && (b8.Text == mark) && (b2.Text == ""))
                return b2;
            if ((b2.Text == mark) && (b8.Text == mark) && (b5.Text == ""))
                return b5;

            if ((b3.Text == mark) && (b6.Text == mark) && (b9.Text == ""))
                return b9;
            if ((b6.Text == mark) && (b9.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b3.Text == mark) && (b9.Text == mark) && (b6.Text == ""))
                return b6;

            //DIAGONAL TESTS
            if ((b1.Text == mark) && (b5.Text == mark) && (b9.Text == ""))
                return b9;
            if ((b5.Text == mark) && (b9.Text == mark) && (b1.Text == ""))
                return b1;
            if ((b1.Text == mark) && (b9.Text == mark) && (b5.Text == ""))
                return b5;

            if ((b3.Text == mark) && (b5.Text == mark) && (b7.Text == ""))
                return b7;
            if ((b5.Text == mark) && (b7.Text == mark) && (b3.Text == ""))
                return b3;
            if ((b3.Text == mark) && (b7.Text == mark) && (b5.Text == ""))
                return b5;

            return null;
        }


        private void checkForWinner()
        {
            bool a_winner = false;

            //horizontal
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            a_winner = true;
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
                a_winner = true;
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
                a_winner = true;
            else if ((b10.Text == b11.Text) && (b11.Text == b12.Text) && (!b10.Enabled))
                a_winner = true;
            else if ((b13.Text == b14.Text) && (b14.Text == b15.Text) && (!b13.Enabled))
                a_winner = true;
            else if ((b16.Text == b17.Text) && (b17.Text == b18.Text) && (!b16.Enabled))
                a_winner = true;

            //vertical
            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
                a_winner = true;
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
                a_winner = true;
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
                a_winner = true;
            else if ((b10.Text == b13.Text) && (b13.Text == b16.Text) && (!b10.Enabled))
                a_winner = true;
            else if ((b11.Text == b14.Text) && (b14.Text == b17.Text) && (!b11.Enabled))
                a_winner = true;
            else if ((b12.Text == b15.Text) && (b15.Text == b18.Text) && (!b12.Enabled))
                a_winner = true;

            //diagonal
            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
                a_winner = true;
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
                a_winner = true;
            else if ((b10.Text == b14.Text) && (b14.Text == b18.Text) && (!b10.Enabled))
                a_winner = true;
            else if ((b12.Text == b14.Text) && (b14.Text == b16.Text) && (!b12.Enabled))
                a_winner = true;

            if (a_winner)
            {
                disableButtons();
                String winner = "";
                if (turn)
                {
                    winner = p2.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = p1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!", "Winner");
            }
            else
            {
                if (turn_count == 18)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("It's a Tie", "Draw");

                }
            }
        }

        private void disableButtons()
        {
            foreach(Control c in Controls)
            {
                if (c is Button)
                {
                    
                    c.Enabled = false;

                }
            }
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.Text = "";
                }
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetCountWinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text= "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer= false;
        }
    }   

}