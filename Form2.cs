using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkceIngProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=TurkceIng;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "INSERT INTO TurkceIng(Turkce,Ingilizce) VALUES ('" + TxtTr.Text + "'," + "'" + txtInglzc.Text + "')";
            comm.Connection = connection;
            connection.Open();
            comm.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("İşlem gerçekleşti");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=TurkceIng;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "delete from TurkceIng where Turkce = '" + TxtTr.Text + "'";
            comm.Connection = connection;
            connection.Open();
            int a = comm.ExecuteNonQuery();
            TxtTr.Text = string.Empty;
            txtInglzc.Text = string.Empty;
            connection.Close();
            MessageBox.Show("İşlem gerçekleşti");
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=TurkceIng;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataTable dTable = new DataTable();
            using (SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM TurkceIng",connection))
            {
                dAdapter.Fill(dTable);
            }
            dataGridView1.DataSource = dTable;
        }
    }
}
