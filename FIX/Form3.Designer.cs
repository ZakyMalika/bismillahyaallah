namespace ucp1
{
    partial class Form3
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvPrestasi = new System.Windows.Forms.DataGridView();
            this.txtid_Prestasi = new System.Windows.Forms.TextBox();
            this.txtNama_Prestasi = new System.Windows.Forms.TextBox();
            this.txttingkat_Prestasi = new System.Windows.Forms.TextBox();
            this.txttahun_Prestasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestasi)).BeginInit();
            this.SuspendLayout();

            // btnCreate
            this.btnCreate.BackColor = System.Drawing.Color.Lime;
            this.btnCreate.Location = new System.Drawing.Point(64, 575);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 36);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.Lime;
            this.btnDelete.Location = new System.Drawing.Point(64, 620);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnUpdate
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Location = new System.Drawing.Point(186, 620);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // dgvPrestasi
            this.dgvPrestasi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPrestasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestasi.Location = new System.Drawing.Point(357, 133);
            this.dgvPrestasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPrestasi.Name = "dgvPrestasi";
            this.dgvPrestasi.RowHeadersWidth = 51;
            this.dgvPrestasi.RowTemplate.Height = 24;
            this.dgvPrestasi.Size = new System.Drawing.Size(748, 492);
            this.dgvPrestasi.TabIndex = 3;
            this.dgvPrestasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestasi_CellClick);

            // txtid_Prestasi
            this.txtid_Prestasi.Location = new System.Drawing.Point(50, 133);
            this.txtid_Prestasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid_Prestasi.Name = "txtid_Prestasi";
            this.txtid_Prestasi.ReadOnly = true;
            this.txtid_Prestasi.Size = new System.Drawing.Size(148, 31);
            this.txtid_Prestasi.TabIndex = 4;

            // txtNama_Prestasi
            this.txtNama_Prestasi.Location = new System.Drawing.Point(50, 228);
            this.txtNama_Prestasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama_Prestasi.Name = "txtNama_Prestasi";
            this.txtNama_Prestasi.Size = new System.Drawing.Size(148, 31);
            this.txtNama_Prestasi.TabIndex = 5;

            // txttingkat_Prestasi
            this.txttingkat_Prestasi.Location = new System.Drawing.Point(50, 327);
            this.txttingkat_Prestasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttingkat_Prestasi.Name = "txttingkat_Prestasi";
            this.txttingkat_Prestasi.Size = new System.Drawing.Size(148, 31);
            this.txttingkat_Prestasi.TabIndex = 6;

            // txttahun_Prestasi
            this.txttahun_Prestasi.Location = new System.Drawing.Point(50, 423);
            this.txttahun_Prestasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttahun_Prestasi.Name = "txttahun_Prestasi";
            this.txttahun_Prestasi.Size = new System.Drawing.Size(148, 31);
            this.txttahun_Prestasi.TabIndex = 7;

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "id_Prestasi";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama_Prestasi";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "tingkat_Prestasi";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "tahun_Prestasi";

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(220, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(958, 52);
            this.label5.TabIndex = 12;
            this.label5.Text = "DATA PRESTASI ATLET FAKULTAS TEKNIK";

            // Form3
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttahun_Prestasi);
            this.Controls.Add(this.txttingkat_Prestasi);
            this.Controls.Add(this.txtNama_Prestasi);
            this.Controls.Add(this.txtid_Prestasi);
            this.Controls.Add(this.dgvPrestasi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "PRESTASI ATLET";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvPrestasi;
        private System.Windows.Forms.TextBox txtid_Prestasi;
        private System.Windows.Forms.TextBox txtNama_Prestasi;
        private System.Windows.Forms.TextBox txttingkat_Prestasi;
        private System.Windows.Forms.TextBox txttahun_Prestasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
