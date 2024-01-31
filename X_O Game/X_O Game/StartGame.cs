namespace X_O_Game
{
    public partial class StartGame : Form
    {

        private string player1Name;
        private string player2Name;
        private char player1Symbol;
        private char player2Symbol;
        string userx = "";
        string userO = "";
        public StartGame()
        {
            InitializeComponent();
        }


        private void btnStartGame_Click(object sender, EventArgs e)
        {
            player1Name = textBox1.Text;
            player2Name = textBox2.Text;
            player1Symbol = rb1.Checked ? 'X' : 'O';
            player2Symbol = player1Symbol == 'X' ? 'O' : 'X';
            ingresar();
        }


        private void ingresar()
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("You must enter the name of players");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You must enter the name of player1");
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("You must enter the name of player2");
                }


            }

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (rb1.Checked && rb4.Checked)
                {
                    userx = textBox1.Text;
                    userO = textBox2.Text;
                    rb2.Enabled = false;
                    rb3.Enabled = false;
                    playGame();

                }
                if (rb2.Checked && rb3.Checked)
                {
                    userx = textBox2.Text;
                    userO = textBox2.Text;
                    rb1.Enabled = false;
                    rb4.Enabled = false;
                    playGame();
                }
                if (rb1.Checked && rb3.Checked)
                {
                    MessageBox.Show("sorry but it is not allow to choose the same symbol for two players ");
                }
                if (rb2.Checked && rb4.Checked)
                {
                    MessageBox.Show("sorry but it is not allow to choose the same symbol for two players ");
                }
                if (rb1.Checked == false && rb2.Checked == false || rb3.Checked == false && rb4.Checked == false)
                {
                    MessageBox.Show("you must select x or o for each player  ");
                }


            }


        }



        private void playGame()
        {
            Playing form2 = new Playing(player1Name, player2Name, player1Symbol, player2Symbol);
            this.Hide();

            form2.ShowDialog();
            this.Close();

        }

    }
}
