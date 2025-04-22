using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;


namespace FIX
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-K2MUUDE\\ZAKYMALIKA; initial catalog=keuangan;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Load the form and initialize components
        }
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtProdi.Clear();
            txtAngkatan.Clear();
            txtCabor.Clear();

            //fokus kembali kenim agar user siap memasukkan data baru
            txtNIM.Focus();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
                try
                {
                    connection.Open();
                    string query = "Select NIM, Nama , Prodi, Angkatan, " + "Cabor from Atlit";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMahasiswa.AutoGenerateColumns = true;
                    dgvMahasiswa.DataSource = dt;

                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message,
                        "Kesalahan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (txtNIM.Text == "" || txtNama.Text == "" || txtProdi.Text == "" || txtAngkatan.Text == "" || txtCabor.Text == "")
                    {
                        MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    conn.Open();
                    string query = "INSERT INTO Atlit (NIM, Nama, Prodi, Angkatan, Cabor) VALUES (@NIM, @Nama, @Prodi, @Angkatan, @Cabor)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIM", txtNIM.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nama", txtNama.Text.Trim());
                        cmd.Parameters.AddWithValue("@Prodi", txtProdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Angkatan", txtAngkatan.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cabor", txtCabor.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak berhasil ditambahkan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNIM.Text))
            {
                MessageBox.Show("Pilih data yang akan diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    if (txtNIM.Text == "" || txtNama.Text == "" || txtProdi.Text == "" ||
                        txtAngkatan.Text == "" || txtCabor.Text == "")
                    {
                        MessageBox.Show("Harap isi semua data!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    conn.Open();
                    string query = @"UPDATE Atlit 
                           SET Nama = @Nama, 
                               Prodi = @Prodi, 
                               Angkatan = @Angkatan, 
                               Cabor = @Cabor 
                           WHERE NIM = @NIM";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIM", txtNIM.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nama", txtNama.Text.Trim());
                        cmd.Parameters.AddWithValue("@Prodi", txtProdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@Angkatan", txtAngkatan.Text.Trim());
                        cmd.Parameters.AddWithValue("@Cabor", txtCabor.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diupdate!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal diupdate!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMahasiswa.SelectedRows.Count > 0)
            {
                DialogResult config = MessageBox.Show(
                    "Yakin ingin menghapus data ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (config == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {

                        try
                        {
                            string nim = dgvMahasiswa.SelectedRows[0].Cells["NIM"].Value.ToString();
                            conn.Open();
                            string query = "Delete from Atlit where NIM = @NIM";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@NIM", nim);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show(
                                    "Data berhasil dihapus",
                                    "Sukses",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                                LoadData();
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Data gagal dihapus", "Kesalahan",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                "Error: " + ex.Message,
                                "Kesalahan",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Harap pilih data yang akan dihapus",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

            MessageBox.Show($"Jumlah Kolom: {dgvMahasiswa.ColumnCount}\nJumlah Baris: {dgvMahasiswa.RowCount}",
                "Debugging DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];

                txtNIM.Text = row.Cells[0].Value?.ToString();
                txtNama.Text = row.Cells[1].Value?.ToString();
                txtProdi.Text = row.Cells[2].Value?.ToString();
                txtAngkatan.Text = row.Cells[3].Value?.ToString();
                txtCabor.Text = row.Cells[4].Value?.ToString();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Contoh isi
            // Misal update label atau validasi input.
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Contoh isi
            // Misal tampilkan MessageBox atau proses lain.
        }
    }

}