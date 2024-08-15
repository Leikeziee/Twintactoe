namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x turn, false = o turn
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

            if(a_winner)
            {
                String winner = "";
                if(turn)
                    winner = "O";
                else
                    winner = "X" ;

                MessageBox.Show(winner + "Wins!", "Winner");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}