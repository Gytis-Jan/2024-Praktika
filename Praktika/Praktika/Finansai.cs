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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Praktika
{
    public partial class Finansai : Form
    {
        public SqlConnection conn;
        string connectionString = @"Data Source = LAPTOP-3PN1HNMR\SQLEXPRESS; Initial Catalog = pajamos; User ID = sa; Password = sa;";
        private int currentDaugiklis = 1;
        private string loggedIn;
        private string reportType;

        public Finansai(string username)
        {
            InitializeComponent();
            loadTipas();
            loadMokejimas();
            //loadSaltinis();

            loggedIn = username;
            currentLogin.Text = loggedIn;
        }

        private void logoff_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atsijungta");

            Loginas log = new Loginas();
            log.Show();
            this.Hide();
        }

        private void showDB_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"SELECT finansai.id, suma, data, pastaba, saltinis, pavadinimas, mokejimas FROM finansai inner join asmuo ON finansai.asmuo_id = asmuo.id
                               inner join klasifikatorius ON klasifikatorius_id = klasifikatorius.id
                               inner join tipas ON tipas_id = tipas.id
                               inner join mokejimas_budas ON mokejimas_id = mokejimas_budas.id;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "pajamos");
                    dataGridView1.DataSource = ds.Tables["pajamos"].DefaultView;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM finansai WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand delSQL = new SqlCommand(query, conn);

                    delSQL.Parameters.Add("@id", SqlDbType.NVarChar).Value = delTextBox.Text;
                    delSQL.ExecuteNonQuery();

                    System.Threading.Thread.Sleep(200);

                    showDB_btn_Click(sender, e);

                    UpdateFinansai();

                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Err : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadTipas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT pavadinimas FROM Tipas";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string tipas = reader["pavadinimas"].ToString();
                        tipasListBox.Items.Add(tipas);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
            }
        }

        private void loadMokejimas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT mokejimas FROM mokejimas_budas";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string pay = reader["mokejimas"].ToString();
                        mokejimoListBox.Items.Add(pay);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
            }
        }

        /*private void loadSaltinis()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT saltinis FROM klasifikatorius";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string type = reader["saltinis"].ToString();
                        saltinisComboBox.Items.Add(type);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
            }
        }*/

        private void tipasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipasListBox.SelectedIndex == -1)
            {
                return;
            }

            string selectedTipas = tipasListBox.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string queryTipasID = "SELECT id, daugiklis FROM tipas WHERE pavadinimas = @pavadinimas";

                    SqlCommand cmdTipasID = new SqlCommand(queryTipasID, conn);
                    cmdTipasID.Parameters.AddWithValue("@pavadinimas", selectedTipas);

                    int tipasID = -1;

                    using (SqlDataReader reader = cmdTipasID.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tipasID = (int)reader["id"];
                            currentDaugiklis = (int)reader["daugiklis"];
                        }
                    }

                    if (tipasID == -1)
                    {
                        MessageBox.Show("Err : Could not find the tipas ID.");
                        return;
                    }

                    string querySaltinis = "SELECT saltinis FROM klasifikatorius WHERE tipas_id = @tipas_id";

                    SqlCommand cmdSaltinis = new SqlCommand(querySaltinis, conn);
                    cmdSaltinis.Parameters.AddWithValue("@tipas_id", tipasID);

                    using (SqlDataReader readerSaltinis = cmdSaltinis.ExecuteReader())
                    {
                        saltinisComboBox.Items.Clear();
                        while (readerSaltinis.Read())
                        {
                            string saltinis = readerSaltinis["saltinis"].ToString();
                            saltinisComboBox.Items.Add(saltinis);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
            }
        }

        private void PopulateTextBox(DataGridViewRow selected)
        {
            if (selected != null)
            {
                sumaTextBox.Text = selected.Cells["suma"].Value.ToString();
                datosParinktis.Value = (DateTime)selected.Cells["data"].Value;
                komentarasTextBox.Text = selected.Cells["pastaba"].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selected = dataGridView1.Rows[e.RowIndex];
                PopulateTextBox(selected);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int gridID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                string updatedSum = sumaTextBox.Text;
                DateTime updatedDate = datosParinktis.Value;
                string updatedKomentaras = komentarasTextBox.Text;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "UPDATE finansai SET suma = @suma, data = @data, pastaba = @pastaba WHERE id = @gridID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@suma", updatedSum);
                            cmd.Parameters.AddWithValue("@data", updatedDate);
                            cmd.Parameters.AddWithValue("@pastaba", updatedKomentaras);
                            cmd.Parameters.AddWithValue("@gridID", gridID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Atnaujinta sekmingai");

                                System.Threading.Thread.Sleep(500);

                                showDB_btn_Click(sender, e);

                                UpdateFinansai();
                            }

                            else
                            {
                                MessageBox.Show("Atnaujinti nepavyko");
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Pasirinkite kuria ivesti norite atnaujinti");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void pildyti_btn_Click(object sender, EventArgs e)
        {
            string suma = sumaTextBox.Text;
            DateTime date = datosParinktis.Value;
            string komentaras = komentarasTextBox.Text;

            if (tipasListBox.SelectedIndex == -1 || mokejimoListBox.SelectedIndex == -1 || saltinisComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Butina pasirinkti 'Tipas', 'Mokejimas', ir 'Saltinis' parinktis");
                return;
            }

            string tipas = tipasListBox.SelectedItem.ToString();
            string mokejimas = mokejimoListBox.SelectedItem.ToString();
            string saltinis = saltinisComboBox.SelectedItem.ToString();

            try
            {
                int mokejimasID = GetMokejimasID(mokejimas);
                int klasifikatoriusID = GetKlasifikatoriusID(saltinis, tipas);
                int asmuoID = GetAsmuoID(loggedIn);

                int daugiklis = GetDaugiklis(tipas);

                decimal parsedSuma = decimal.Parse(suma) * daugiklis;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO finansai (suma, data, pastaba, mokejimas_id, klasifikatorius_id, asmuo_id) VALUES (@suma, @data, @pastaba, @mokejimasID, @klasifikatoriusID, @asmuoID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@suma", parsedSuma);
                        cmd.Parameters.AddWithValue("@data", date);
                        cmd.Parameters.AddWithValue("@pastaba", komentaras);
                        cmd.Parameters.AddWithValue("@mokejimasID", mokejimasID);
                        cmd.Parameters.AddWithValue("@klasifikatoriusID", klasifikatoriusID);
                        cmd.Parameters.AddWithValue("@asmuoID", asmuoID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Iterpta sekmingai");

                            System.Threading.Thread.Sleep(200);

                            showDB_btn_Click(sender, e);
                            UpdateFinansai();
                        }
                        else
                        {
                            MessageBox.Show("Nepavyko iterpti");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err : " + ex.Message);
            }
        }

        private int GetMokejimasID(string mokejimas)
        {
            string query = "SELECT id FROM mokejimas_budas WHERE mokejimas = @mokejimas";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mokejimas", mokejimas);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        return id;
                    }
                    else
                    {
                        throw new Exception("Mokejimas FAIL");
                    }
                }
            }
        }

        private int GetKlasifikatoriusID(string saltinis, string tipas)
        {
            string query = "SELECT k.id FROM klasifikatorius k JOIN tipas t ON k.tipas_id = t.id WHERE k.saltinis = @saltinis AND t.pavadinimas = @tipas";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@saltinis", saltinis);
                    cmd.Parameters.AddWithValue("@tipas", tipas);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        return id;
                    }
                    else
                    {
                        throw new Exception("Klasifikatorius FAIL");
                    }
                }
            }
        }

        private int GetAsmuoID(string username)
        {
            string query = "SELECT id FROM asmuo WHERE username = @username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        return id;
                    }
                    else
                    {
                        throw new Exception("Asmuo FAIL");
                    }
                }
            }
        }

        private int GetDaugiklis(string tipas)
        {
            string query = "SELECT daugiklis FROM Tipas WHERE pavadinimas = @pavadinimas";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pavadinimas", tipas);

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int daugiklis))
                    {
                        return daugiklis;
                    }

                    else
                    {
                        throw new Exception("Daugiklis FAIL");
                    }
                }
            }
        }

        private void UpdateFinansai()
        {
            decimal total = 0;
            decimal gain = 0;
            decimal spending = 0;

            string query = @"SELECT f.id, f.suma, f.data, f.pastaba, k.saltinis, t.pavadinimas AS tipas, mb.mokejimas AS mokejimas
                             FROM finansai f
                             INNER JOIN klasifikatorius k ON f.klasifikatorius_id = k.id
                             INNER JOIN tipas t ON k.tipas_id = t.id
                             INNER JOIN mokejimas_budas mb ON f.mokejimas_id = mb.id;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal suma = Convert.ToDecimal(reader["suma"]);
                            string tipas = reader["tipas"].ToString();

                            if (tipas == "Pajamos")
                            {
                                gain += suma;
                            }

                            else if (tipas == "Islaidos")
                            {
                                spending += suma;
                            }
                        }
                    }
                }
            }

            total = gain - Math.Abs(spending);

            likutisLabel.Text = $"{total:C}";
            pajamosLabel.Text = $"{gain:C}";
            islaidosLabel.Text = $"{spending:C}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            pdf.Show();
        }

        private void sumaTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        /*private void reportDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void reportDatePicker2_ValueChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            if (reportDatePicker1.Value != DateTime.MinValue && reportDatePicker2.Value != DateTime.MinValue)
            {
                reportType = "periodas";
            }

            else if (reportComboBox.SelectedItem != null)
            {
                reportType = "saltinis";
            }

            else if (reportListBox.SelectedItem != null)
            {
                reportType = "tipas";
            }

            else
            {
                MessageBox.Show("Pasirinkite ataskaitos parametra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GenerateReport();
        }

        private void GenerateReport()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "";
                    SqlDataAdapter adapter = null;

                    switch (reportType)
                    {
                        case "periodas":
                            query = @"SELECT f.data, k.saltinis AS Source, t.pavadinimas AS Type, f.suma AS Amount 
                                      FROM finansai f
                                      INNER JOIN klasifikatorius k ON f.klasifikatorius_id = k.id
                                      INNER JOIN tipas t ON k.tipas_id = t.id
                                      INNER JOIN mokejimas_budas mb ON f.mokejimas_id = mb.id
                                      WHERE f.data >= @startData AND f.data <= @endData";

                            adapter = new SqlDataAdapter(query, conn);
                            adapter.SelectCommand.Parameters.AddWithValue("@startData", reportDatePicker1.Value);
                            adapter.SelectCommand.Parameters.AddWithValue("@endData", reportDatePicker2.Value);

                            break;

                        case "saltinis":
                            query = @"SELECT f.data, k.saltinis AS Source, t.pavadinimas AS Type, f.suma AS Amount 
                                      FROM finansai f
                                      INNER JOIN klasifikatorius k ON f.klasifikatorius_id = k.id
                                      INNER JOIN tipas t ON k.tipas_id = t.id
                                      INNER JOIN mokejimas_budas mb ON f.mokejimas_id = mb.id
                                      WHERE k.saltinis = @saltinis";

                            adapter = new SqlDataAdapter(query, conn);
                            adapter.SelectCommand.Parameters.AddWithValue("@saltinis", reportComboBox.SelectedItem.ToString());

                            break;

                        case "tipas":
                            query = @"SELECT f.data, k.saltinis AS Source, t.pavadinimas AS Type, f.suma AS Amount 
                                      FROM finansai f
                                      INNER JOIN klasifikatorius k ON f.klasifikatorius_id = k.id
                                      INNER JOIN tipas t ON k.tipas_id = t.id
                                      INNER JOIN mokejimas_budas mb ON f.mokejimas_id = mb.id
                                      WHERE t.pavadinimas = @tipas";

                            adapter = new SqlDataAdapter(query, conn);
                            adapter.SelectCommand.Parameters.AddWithValue("@tipas", reportListBox.SelectedItem.ToString());
                            break;
                    }

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    GeneratePDF(ds);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePDF(DataSet ds)
        {
            string pdfPath = "C:\\Users\\15784\\Kolegija\\2024 Praktika Kolegijoje\\test.pdf";

            PdfWriter writer = new PdfWriter(pdfPath);
            PdfDocument pdf = new PdfDocument(writer);
            Document doc = new Document(pdf);

            doc.Add(new Paragraph($"Finansu Ataskaita ({reportType})"));
            doc.Add(new Paragraph());

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string date = row["data"].ToString();
                string saltinis = row["Source"].ToString();
                string tipas = row["Type"].ToString();
                string kiekis = row["Amount"].ToString();

                doc.Add(new Paragraph($"{date} - {saltinis} - {tipas} - {kiekis}"));
            }

            doc.Close();

            MessageBox.Show("Finansu ataskaita sekmingai sugeneruota!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/

        private void Finansai_Load(object sender, EventArgs e)
        {
            UpdateFinansai();
        }

        private void Finansai_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
