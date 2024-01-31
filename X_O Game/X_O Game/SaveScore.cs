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
    public partial class SaveScore : Form
    {
        SqlConnection con;

        public SaveScore()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.;Database=X_O_Score;Trusted_Connection=True;TrustServerCertificate=True");
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            Getplayers();
        }
        public void Getplayers()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select [Player_1Name],[Player_1Score],[Player_2Name],[Player_2Score],[GameDate] from GameScores;";
;
            sqlCommand.Connection = con;
            con.Open();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            con.Close();

            contain.DataSource = dt;
        }
    }
}
