namespace CRUDMahasiswaADO
{
    partial class FormMahasiswa
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
            this.txtLabel = new System.Windows.Forms.Label();
            this.txtLabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLabel4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(54, 40);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(38, 20);
            this.txtLabel.TabIndex = 0;
            this.txtLabel.Text = "NIM";
            // 
            // txtLabel2
            // 
            this.txtLabel2.AutoSize = true;
            this.txtLabel2.Location = new System.Drawing.Point(54, 90);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(51, 20);
            this.txtLabel2.TabIndex = 1;
            this.txtLabel2.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Kelamin";
            // 
            // textLabel4
            // 
            this.textLabel4.AutoSize = true;
            this.textLabel4.Location = new System.Drawing.Point(54, 185);
            this.textLabel4.Name = "textLabel4";
            this.textLabel4.Size = new System.Drawing.Size(105, 20);
            this.textLabel4.TabIndex = 3;
            this.textLabel4.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kode Prodi";
            // 
            // cmbJK
            // 
            this.cmbJK.FormattingEnabled = true;
            this.cmbJK.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbJK.Location = new System.Drawing.Point(180, 132);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(121, 28);
            this.cmbJK.TabIndex = 6;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(180, 233);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(269, 68);
            this.txtAlamat.TabIndex = 7;
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(180, 315);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(100, 26);
            this.txtKodeProdi.TabIndex = 8;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(180, 185);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalLahir.TabIndex = 9;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(180, 83);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(269, 26);
            this.txtNama.TabIndex = 10;
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(180, 40);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(215, 26);
            this.txtNIM.TabIndex = 11;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(518, 40);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 35);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Membuka Koneksi";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(518, 103);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(161, 33);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Menampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(518, 161);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(161, 34);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Menambah Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(518, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 33);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Mengubah Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(518, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(652, 236);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLabel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLabel2);
            this.Controls.Add(this.txtLabel);
            this.Name = "FormMahasiswa";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.Label txtLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textLabel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

