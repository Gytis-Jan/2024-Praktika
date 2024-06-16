using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Praktika.Session;

namespace Praktika
{
    public partial class Loginas : Form
    {
        public SqlConnection conn;
        string connectionString = @"Data Source = LAPTOP-3PN1HNMR\SQLEXPRESS; Initial Catalog = pajamos; User ID = sa; Password = sa;";

        public Loginas()
        {
            InitializeComponent();
        }

        private void chng_to_reg_btn_Click(object sender, EventArgs e)
        {
            Registracija regist = new Registracija();
            regist.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = userTextBox.Text;
            string password = pswTextBox.Text;

            string query = "SELECT COUNT(*) FROM asmuo WHERE username = @username AND password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            Finansai fin = new Finansai(username);
                            fin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Neteisingas vartotojo vardas ar slaptazodis");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Err: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetUserName(string username)
        {
            string query = "SELECT vardas FROM asmuo WHERE username = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return cmd.ExecuteScalar() as string;
                }
            }
        }

        private void Loginas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}