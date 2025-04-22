namespace ucp1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtjenis_transaksi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsaldo_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttanggal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvKeuangan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeuangan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(12, 47);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(150, 22);
            this.txtNIM.TabIndex = 0;
            // 
            // label1 - NIM
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIM";
            // 
            // txtketerangan
            // 
            this.txtketerangan.Location = new System.Drawing.Point(12, 93);
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.Size = new System.Drawing.Size(150, 22);
            this.txtketerangan.TabIndex = 2;
            // 
            // label2 - Keterangan
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Keterangan";
            // 
            // txtjenis_transaksi
            // 
            this.txtjenis_transaksi.Location = new System.Drawing.Point(12, 139);
            this.txtjenis_transaksi.Name = "txtjenis_transaksi";
            this.txtjenis_transaksi.Size = new System.Drawing.Size(150, 22);
            this.txtjenis_transaksi.TabIndex = 4;
            // 
            // label3 - Jenis Transaksi
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jenis Transaksi";
            // 
            // txtjumlah
            // 
            this.txtjumlah.Location = new System.Drawing.Point(12, 185);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(150, 22);
            this.txtjumlah.TabIndex = 6;
            // 
            // label5 - Jumlah
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jumlah";
            // 
            // txtsaldo_total
            // 
            this.txtsaldo_total.Location = new System.Drawing.Point(12, 231);
            this.txtsaldo_total.Name = "txtsaldo_total";
            this.txtsaldo_total.Size = new System.Drawing.Size(150, 22);
            this.txtsaldo_total.TabIndex = 8;
            // 
            // label6 - Saldo Total
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Saldo Total";
            // 
            // txttanggal
            // 
            this.txttanggal.Location = new System.Drawing.Point(12, 277);
            this.txttanggal.Name = "txttanggal";
            this.txttanggal.Size = new System.Drawing.Size(150, 22);
            this.txttanggal.TabIndex = 10;
            // 
            // label7 - Tanggal
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tanggal";
            // 
            // label8 - Judul
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(200, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(569, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "DATA KEUANGAN MAHASISWA FT UNY";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Lime;
            this.btnCreate.Location = new System.Drawing.Point(200, 370);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 30);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(300, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvKeuangan
            // 
            this.dgvKeuangan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKeuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeuangan.Location = new System.Drawing.Point(200, 70);
            this.dgvKeuangan.Name = "dgvKeuangan";
            this.dgvKeuangan.RowHeadersWidth = 51;
            this.dgvKeuangan.RowTemplate.Height = 24;
            this.dgvKeuangan.Size = new System.Drawing.Size(580, 280);
            this.dgvKeuangan.TabIndex = 15;
            this.dgvKeuangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeuangan_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKeuangan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttanggal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsaldo_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtjenis_transaksi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtketerangan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNIM);
            this.Name = "Form1";
            this.Text = "Laporan Keuangan Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeuangan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtketerangan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtjenis_transaksi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsaldo_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttanggal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvKeuangan;
    }
}
