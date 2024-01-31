using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Playing : Form
    {
        SqlConnection con;
        private string player1Name;
        private string player2Name;
        private char player1Symbol;
        private char player2Symbol;
        private int player1Score = 0;
        private int player2Score = 0;
        private bool isPlayer1Turn = true;


        void Enable_false()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;

        }


        void SwitchPlayerTurn()
        {
            isPlayer1Turn = !isPlayer1Turn;
        }

        void Click_Inter(Button button)
        {
            if (button.Enabled)
            {
                button.Text = (isPlayer1Turn) ? player1Symbol.ToString() : player2Symbol.ToString();
                SwitchPlayerTurn();
                score();
                button.Enabled = false;
            }
        }

        void score()
        {

            if (btnTic1.Text == player1Symbol.ToString() && btnTic2.Text == player1Symbol.ToString() && btnTic3.Text == player1Symbol.ToString())
            {
                
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name}({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
            }
            else if (btnTic1.Text == player2Symbol.ToString() && btnTic2.Text == player2Symbol.ToString() && btnTic3.Text == player2Symbol.ToString())
            {
               
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
            }
            if (btnTic1.Text == player1Symbol.ToString() && btnTic4.Text == player1Symbol.ToString() && btnTic7.Text == player1Symbol.ToString())
            {
                
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            else if (btnTic1.Text == player2Symbol.ToString() && btnTic4.Text == player2Symbol.ToString() && btnTic7.Text == player2Symbol.ToString())
            {
               
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            if (btnTic1.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic9.Text == player1Symbol.ToString())
            {
              
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            else if (btnTic1.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic9.Text == player2Symbol.ToString())
            {
             
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }

            if (btnTic3.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic7.Text == player1Symbol.ToString())
            {

                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            else if (btnTic3.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic7.Text == player2Symbol.ToString())
            {

                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            if (btnTic2.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic8.Text == player1Symbol.ToString())
            {

                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            else if (btnTic2.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic8.Text == player2Symbol.ToString())
            {

                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            if (btnTic3.Text == player1Symbol.ToString() && btnTic6.Text == player1Symbol.ToString() && btnTic9.Text == player1Symbol.ToString())
            {

                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            else if (btnTic3.Text == player2Symbol.ToString() && btnTic6.Text == player2Symbol.ToString() && btnTic9.Text == player2Symbol.ToString())
            {

                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            if (btnTic4.Text == player1Symbol.ToString() && btnTic5.Text == player1Symbol.ToString() && btnTic6.Text == player1Symbol.ToString())
            {
                // Player 1 wins
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            else if (btnTic4.Text == player2Symbol.ToString() && btnTic5.Text == player2Symbol.ToString() && btnTic6.Text == player2Symbol.ToString())
            {
                // Player 2 wins
                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            if (btnTic7.Text == player1Symbol.ToString() && btnTic8.Text == player1Symbol.ToString() && btnTic9.Text == player1Symbol.ToString())
            {
                // Player 1 wins
                player1Score++;
                UpdateScores();
                MessageBox.Show($"{player1Name} ({player1Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }
            else if (btnTic7.Text == player2Symbol.ToString() && btnTic8.Text == player2Symbol.ToString() && btnTic9.Text == player2Symbol.ToString())
            {

                player2Score++;
                UpdateScores();
                MessageBox.Show($"{player2Name} ({player2Symbol}) is Winner ", " X_O Game ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();

            }


        }
        void UpdateScores()
        {
            libpl1.Text = player1Score.ToString();
            libpl2.Text = player2Score.ToString();
        }
        public Playing(string player1Name, string player2Name, char player1Symbol, char player2Symbol)
        {


            InitializeComponent();
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            this.player1Symbol = player1Symbol;
            this.player2Symbol = player2Symbol;
            lbl1.Text = $"{player1Name} ({player1Symbol})";
            lbl2.Text = $"{player2Name} ({player2Symbol})";
            con = new SqlConnection("Server=.;Database=X_O_Score;Trusted_Connection=True;TrustServerCertificate=True");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic1);
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic2);
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic3);
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic4);
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic5);
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic6);
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic7);
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic8);
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {

            Click_Inter(btnTic9);
        }

        void ResetGame()
        {
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;

            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";


            UpdateScores();



        }

        private void button12_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        void NewGame()
        {

            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;

            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";

            player1Score = 0;
            player2Score = 0;
            libpl1.Text = "";
            libpl2.Text = "";



        }

        private void button11_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into GameScores([Player_1Name],[Player_2Name],[Player_1Score],[Player_2Score],[GameDate]) values(@name_1,@name_2,@score_1,@score_2,@Gametime)", con);
            cmd.Parameters.AddWithValue("name_1", player1Name);
            cmd.Parameters.AddWithValue("name_2", player2Name);
            cmd.Parameters.AddWithValue("score_1", libpl1.Text);
            cmd.Parameters.AddWithValue("score_2", libpl2.Text);
            cmd.Parameters.AddWithValue("Gametime", DateTime.Now);

            int rowsEffected = 0;
            try
            {

                con.Open();

                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data was saved");

            }

            SaveScore saveScore = new SaveScore();
            this.Hide();

            saveScore.ShowDialog();
            this.Close();


        }
    }
}
