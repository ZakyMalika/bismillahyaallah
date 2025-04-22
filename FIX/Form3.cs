using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ucp1
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=DESKTOP-K2MUUDE\\ZAKYMALIKA;Initial Catalog=keuangan;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearForm()
        {
            txtid_Prestasi.Clear();
            txtNama_Prestasi.Clear();
            txttingkat_Prestasi.Clear();
            txttahun_Prestasi.Clear();
            txtid_Prestasi.Focus();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_Prestasi, Nama_Prestasi, tingkat_Prestasi, tahun_Prestasi FROM Prestasi";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPrestasi.AutoGenerateColumns = true;
                    dgvPrestasi.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (txtid_Prestasi.Text == "" || txtNama_Prestasi.Text == "" || txttingkat_Prestasi.Text == "" || txttahun_Prestasi.Text == "")
                    {
                        MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    conn.Open();
                    string query = "INSERT INTO Prestasi (id_Prestasi, Nama_Prestasi, tingkat_Prestasi, tahun_Prestasi) VALUES (@id, @nama, @tingkat, @tahun)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtid_Prestasi.Text.Trim());
                        cmd.Parameters.AddWithValue("@nama", txtNama_Prestasi.Text.Trim());
                        cmd.Parameters.AddWithValue("@tingkat", txttingkat_Prestasi.Text.Trim());
                        cmd.Parameters.AddWithValue("@tahun", txttahun_Prestasi.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal ditambahkan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPrestasi.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string id = dgvPrestasi.SelectedRows[0].Cells["id_Prestasi"].Value.ToString();
                            conn.Open();
                            string query = "DELETE FROM Prestasi WHERE id_Prestasi = @id";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Data gagal dihapus!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Harap pilih data yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show($"Jumlah Kolom: {dgvPrestasi.ColumnCount}\nJumlah Baris: {dgvPrestasi.RowCount}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvPrestasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPrestasi.Rows[e.RowIndex];

                txtid_Prestasi.Text = row.Cells[0].Value?.ToString();
                txtNama_Prestasi.Text = row.Cells[1].Value?.ToString();
                txttingkat_Prestasi.Text = row.Cells[2].Value?.ToString();
                txttahun_Prestasi.Text = row.Cells[3].Value?.ToString();
            }
        }
        private void dgvKeuangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kamu bisa isi logika di sini kalau memang perlu
        }

    }
}
