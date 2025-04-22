using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ucp1
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-K2MUUDE\\ZAKYMALIKA;Initial Catalog=keuangan;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearForm()
        {
            txtNIM.Clear();
            txtjenis_transaksi.Clear();
            txtjumlah.Clear();
            txtsaldo_total.Clear();
            txttanggal.Clear();
            txtketerangan.Clear();
            txtNIM.Focus();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT NIM, jenis_transaksi, jumlah, saldo_total, tanggal, keterangan FROM DataKeuangan";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvKeuangan.AutoGenerateColumns = true;
                    dgvKeuangan.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsFormValid()
        {
            return !(string.IsNullOrWhiteSpace(txtNIM.Text) ||
                     string.IsNullOrWhiteSpace(txtjenis_transaksi.Text) ||
                     string.IsNullOrWhiteSpace(txtjumlah.Text) ||
                     string.IsNullOrWhiteSpace(txtsaldo_total.Text) ||
                     string.IsNullOrWhiteSpace(txttanggal.Text) ||
                     string.IsNullOrWhiteSpace(txtketerangan.Text));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtjenis_transaksi.Text.ToLower() != "pemasukan" && txtjenis_transaksi.Text.ToLower() != "pengeluaran")
            {
                MessageBox.Show("Jenis transaksi hanya bisa 'pemasukan' atau 'pengeluaran'.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO DataKeuangan (NIM, jenis_transaksi, jumlah, saldo_total, tanggal, keterangan) " +
                                   "VALUES (@NIM, @jenis_transaksi, @jumlah, @saldo_total, @tanggal, @keterangan)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIM", txtNIM.Text.Trim());
                        cmd.Parameters.AddWithValue("@jenis_transaksi", txtjenis_transaksi.Text.Trim());

                        if (!decimal.TryParse(txtjumlah.Text.Trim(), out decimal jumlah) ||
                            !decimal.TryParse(txtsaldo_total.Text.Trim(), out decimal saldo) ||
                            !DateTime.TryParse(txttanggal.Text.Trim(), out DateTime tanggal))
                        {
                            MessageBox.Show("Jumlah, saldo, dan tanggal harus dalam format yang benar.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@saldo_total", saldo);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text.Trim());

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
            if (dgvKeuangan.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            string id = dgvKeuangan.SelectedRows[0].Cells["id_keuangan"].Value.ToString();
                            conn.Open();
                            string query = "DELETE FROM DataKeuangan WHERE id_keuangan = @id";
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
            MessageBox.Show($"Jumlah Kolom: {dgvKeuangan.ColumnCount}\nJumlah Baris: {dgvKeuangan.RowCount}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvKeuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKeuangan.Rows[e.RowIndex];
                txtNIM.Text = row.Cells["NIM"].Value?.ToString();
                txtjenis_transaksi.Text = row.Cells["jenis_transaksi"].Value?.ToString();
                txtjumlah.Text = row.Cells["jumlah"].Value?.ToString();
                txtsaldo_total.Text = row.Cells["saldo_total"].Value?.ToString();
                txttanggal.Text = row.Cells["tanggal"].Value?.ToString();
                txtketerangan.Text = row.Cells["keterangan"].Value?.ToString();
            }
        }
    }
}
