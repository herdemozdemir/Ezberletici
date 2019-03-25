using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkceIngProje
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string connectionString;
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection();
            command = new SqlCommand();
            connectionString = ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            connection.ConnectionString = connectionString;

        }
        private void btnGstr_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT Turkce,Ingilizce  FROM TurkceIng ORDER BY NEWID()";
            command.CommandText = sorgu;
            command.Connection = connection;

            connection.Open(); 
            var reader = command.ExecuteReader();
            bool kayitVarmi = reader.Read();
            if(reader.Read())
            {
                Random rnd = new Random();
                rnd.Next(1, 3);
                string Trkc = (string)reader["Turkce"];
                string Ing = (string)reader["Ingilizce"];
                TxtTurkce.Text = Trkc;
                txtIng.Text = Ing;
            }
            connection.Close();
            reader.Close();
        }
        private void btnAyrlr_Click(object sender, EventArgs e)
        {
            Form x = new Form2();
            x.Show();

        }
    }
}
