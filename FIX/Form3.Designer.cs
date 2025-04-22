namespace ucp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(43, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(43, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(124, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvPrestasi
            // 
            this.dgvPrestasi.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPrestasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestasi.Location = new System.Drawing.Point(238, 85);
            this.dgvPrestasi.Name = "dgvPrestasi";
            this.dgvPrestasi.RowHeadersWidth = 51;
            this.dgvPrestasi.RowTemplate.Height = 24;
            this.dgvPrestasi.Size = new System.Drawing.Size(499, 315);
            this.dgvPrestasi.TabIndex = 3;
            this.dgvPrestasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeuangan_CellContentClick);
            // 
            // txtid_Prestasi
            // 
            this.txtid_Prestasi.Location = new System.Drawing.Point(33, 85);
            this.txtid_Prestasi.Name = "txtid_Prestasi";
            this.txtid_Prestasi.Size = new System.Drawing.Size(100, 22);
            this.txtid_Prestasi.TabIndex = 4;
            // 
            // txtNama_Prestasi
            // 
            this.txtNama_Prestasi.Location = new System.Drawing.Point(33, 146);
            this.txtNama_Prestasi.Name = "txtNama_Prestasi";
            this.txtNama_Prestasi.Size = new System.Drawing.Size(100, 22);
            this.txtNama_Prestasi.TabIndex = 5;
            // 
            // txttingkat_Prestasi
            // 
            this.txttingkat_Prestasi.Location = new System.Drawing.Point(33, 209);
            this.txttingkat_Prestasi.Name = "txttingkat_Prestasi";
            this.txttingkat_Prestasi.Size = new System.Drawing.Size(100, 22);
            this.txttingkat_Prestasi.TabIndex = 6;
            // 
            // txttahun_Prestasi
            // 
            this.txttahun_Prestasi.Location = new System.Drawing.Point(33, 271);
            this.txttahun_Prestasi.Name = "txttahun_Prestasi";
            this.txttahun_Prestasi.Size = new System.Drawing.Size(100, 22);
            this.txttahun_Prestasi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "id_Prestasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama_Prestasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "tingkat_Prestasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "tahun_prestasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(626, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "DATA PRESTASI ATLET FAKULTAS TEKNIK";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "PRESTASI ATLET";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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