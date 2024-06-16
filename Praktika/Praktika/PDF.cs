using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Praktika
{
    public partial class PDF : Form
    {
        public SqlConnection conn;
        string connectionString = @"Data Source = LAPTOP-3PN1HNMR\SQLEXPRESS; Initial Catalog = pajamos; User ID = sa; Password = sa;";
        private int currentDaugiklis = 1;
        private string reportType;

        public PDF()
        {
            InitializeComponent();
            loadReportList();
            loadReportBox();
        }

        private void loadReportList()
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
                        reportListBox.Items.Add(tipas);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
            }
        }

        private void loadReportBox()
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
                        reportComboBox.Items.Add(type);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            reportDatePicker1.Value = DateTime.Today.AddDays(-30);
            reportDatePicker2.Value = DateTime.Today;
            reportListBox.SelectedItem = null;
            reportComboBox.SelectedItem = null;
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            try
            {
                // Check if selection is made in combo boxes
                if (reportComboBox.SelectedItem == null && reportListBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select options in at least one combo box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "";
                    SqlDataAdapter adapter = null;

                    // Determine the query based on the report type
                    if (reportDatePicker1.Value != DateTime.MinValue && reportDatePicker2.Value != DateTime.MinValue)
                    {
                        query = @"SELECT f.data, k.saltinis AS Source, t.pavadinimas AS Type, f.suma AS Amount, f.pastaba 
                                  FROM finansai f
                                  INNER JOIN klasifikatorius k ON f.klasifikatorius_id = k.id
                                  INNER JOIN tipas t ON k.tipas_id = t.id
                                  INNER JOIN mokejimas_budas mb ON f.mokejimas_id = mb.id
                                  WHERE f.data >= @startData AND f.data <= @endData";
                        adapter = new SqlDataAdapter(query, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@startData", reportDatePicker1.Value);
                        adapter.SelectCommand.Parameters.AddWithValue("@endData", reportDatePicker2.Value);
                    }
                    else if (reportComboBox.SelectedItem != null)
                    {
                        query = @"SELECT f.data, k.saltinis AS Source, t.pavadinimas AS Type, f.suma AS Amount, f.pastaba 
                                  FROM finansai f
                                  INNER JOIN klasifikatorius k ON f.klasifikatorius_id = k.id
                                  INNER JOIN tipas t ON k.tipas_id = t.id
                                  INNER JOIN mokejimas_budas mb ON f.mokejimas_id = mb.id
                                  WHERE k.saltinis = @saltinis";
                        adapter = new SqlDataAdapter(query, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@saltinis", reportComboBox.SelectedItem.ToString());
                    }
                    else if (reportListBox.SelectedItem != null)
                    {
                        query = @"SELECT f.data, k.saltinis AS Source, t.pavadinimas AS Type, f.suma AS Amount, f.pastaba 
                                  FROM finansai f
                                  INNER JOIN klasifikatorius k ON f.klasifikatorius_id = k.id
                                  INNER JOIN tipas t ON k.tipas_id = t.id
                                  INNER JOIN mokejimas_budas mb ON f.mokejimas_id = mb.id
                                  WHERE t.pavadinimas = @tipas";
                        adapter = new SqlDataAdapter(query, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("@tipas", reportListBox.SelectedItem.ToString());
                    }

                    // Check if the adapter is null
                    if (adapter == null)
                    {
                        MessageBox.Show("Invalid report parameters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Generate PDF report
                    GeneratePDF(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratePDF(DataSet ds)
        {
            string filePath = "chart.pdf";

            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document document = new Document(pdf))
                {
                    Paragraph title = new Paragraph("Duomenys paimti iš duomenų bazės");
                    document.Add(title);
                    document.Add(new Paragraph("\n"));

                    Table table = new Table(new float[] { 1, 1, 1, 1, 1 });
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Data")));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Suma")));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Tipas")));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Pavadinimas")));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Pinigų Šaltinis")));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Pastaba")));

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(row["data"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["suma"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Type"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["Source"].ToString())));
                        table.AddCell(new Cell().Add(new Paragraph(row["pastaba"].ToString())));
                    }

                    document.Add(table);
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    Title = "Save PDF File",
                    FileName = "ataskaita.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Move(filePath, saveFileDialog.FileName);
                    MessageBox.Show("PDF išsaugotas sėkmingai.");
                }
                else
                {
                    MessageBox.Show("PDF sukurimas nutrauktas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida sukuriant PDF: {ex.Message}");
            }
        }
    }
}
