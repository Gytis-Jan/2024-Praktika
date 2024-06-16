using System;
using System.Data;
using System.Data.SqlClient;

namespace Praktika
{
    public partial class Registracija : Form
    {
        public SqlConnection conn;
        string connectionString = @"Data Source = LAPTOP-3PN1HNMR\SQLEXPRESS; Initial Catalog = pajamos; User ID = sa; Password = sa;";

        public Registracija()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chng_to_lgn_btn_Click(object sender, EventArgs e)
        {
            Loginas loginas = new Loginas();
            loginas.Show();
            this.Hide();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            string username = usrnmTextBox.Text;
            string password = pswTextBox.Text;
            string vardas = varTextBox.Text;
            string pavarde = pavTextBox.Text;
            string telNr = tel_nrTextBox.Text;

            string asmensKod = GenerateNumber();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO asmuo (vardas, pavarde, tel_nr, username, password, a_k) VALUES (@vardas, @pavarde, @tel_nr, @username, @password, @a_k)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@vardas", vardas);
                cmd.Parameters.AddWithValue("@pavarde", pavarde);
                cmd.Parameters.AddWithValue("@tel_nr", telNr);
                cmd.Parameters.AddWithValue("@a_k", asmensKod);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registracija sekminga!");
                    }

                    else
                    {
                        MessageBox.Show("Ivyko klaida, toks vartotojaus jau egzistuoja!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Klaida : " + ex.Message);
                }
            }
        }

        private string GenerateNumber()
        {
            Random rnd = new Random();
            string first = "5";

            int year = rnd.Next(90, 105);
            string yearStr = (year > 99 ? (year - 100).ToString("D2") : year.ToString());

            int month = rnd.Next(1, 13);
            string monthStr = month.ToString("D2");

            int day = rnd.Next(1, 32);
            string dayStr = day.ToString("D2");

            int randomDigit = rnd.Next(0, 10000);
            string randomDigitStr = randomDigit.ToString("D4");

            return first + yearStr + monthStr + dayStr + randomDigitStr;
        }

        private void Registracija_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
