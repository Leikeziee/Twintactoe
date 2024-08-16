namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x turn, false = o turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    winner = "O";
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + "Wins!", "Winner");
            }
            else
            {
                if (turn_count == 18)
                    MessageBox.Show("It's a Tie", "Draw");

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

        private void label1_Click_1(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }   

}