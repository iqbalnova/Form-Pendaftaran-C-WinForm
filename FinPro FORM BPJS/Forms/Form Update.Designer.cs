namespace FinPro_FORM_BPJS.Forms
{
    partial class Form_Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_iuran = new System.Windows.Forms.ComboBox();
            this.cmb_pekerjaan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.rd_perempuan = new System.Windows.Forms.RadioButton();
            this.rd_laki = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_tempat = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_nik = new System.Windows.Forms.TextBox();
            this.txt_kk = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Pekerjaan";
            // 
            // cmb_iuran
            // 
            this.cmb_iuran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_iuran.FormattingEnabled = true;
            this.cmb_iuran.Location = new System.Drawing.Point(490, 39);
            this.cmb_iuran.Name = "cmb_iuran";
            this.cmb_iuran.Size = new System.Drawing.Size(121, 21);
            this.cmb_iuran.TabIndex = 67;
            this.cmb_iuran.SelectedIndexChanged += new System.EventHandler(this.cmb_iuran_SelectedIndexChanged);
            // 
            // cmb_pekerjaan
            // 
            this.cmb_pekerjaan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_pekerjaan.FormattingEnabled = true;
            this.cmb_pekerjaan.Location = new System.Drawing.Point(490, 12);
            this.cmb_pekerjaan.Name = "cmb_pekerjaan";
            this.cmb_pekerjaan.Size = new System.Drawing.Size(121, 21);
            this.cmb_pekerjaan.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Iuran";
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_upload.Location = new System.Drawing.Point(290, 138);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(94, 22);
            this.btn_upload.TabIndex = 64;
            this.btn_upload.Text = "BROWSE";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // rd_perempuan
            // 
            this.rd_perempuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rd_perempuan.AutoSize = true;
            this.rd_perempuan.Location = new System.Drawing.Point(184, 141);
            this.rd_perempuan.Name = "rd_perempuan";
            this.rd_perempuan.Size = new System.Drawing.Size(79, 17);
            this.rd_perempuan.TabIndex = 62;
            this.rd_perempuan.TabStop = true;
            this.rd_perempuan.Text = "Perempuan";
            this.rd_perempuan.UseVisualStyleBackColor = true;
            this.rd_perempuan.CheckedChanged += new System.EventHandler(this.rd_perempuan_CheckedChanged);
            // 
            // rd_laki
            // 
            this.rd_laki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rd_laki.AutoSize = true;
            this.rd_laki.Location = new System.Drawing.Point(102, 141);
            this.rd_laki.Name = "rd_laki";
            this.rd_laki.Size = new System.Drawing.Size(70, 17);
            this.rd_laki.TabIndex = 61;
            this.rd_laki.TabStop = true;
            this.rd_laki.Text = "Laki - laki";
            this.rd_laki.UseVisualStyleBackColor = true;
            this.rd_laki.CheckedChanged += new System.EventHandler(this.rd_laki_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Tempat, Tgl Lahir";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "No. NIK";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "No. KK";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nama";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // txt_tempat
            // 
            this.txt_tempat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tempat.Location = new System.Drawing.Point(102, 106);
            this.txt_tempat.Name = "txt_tempat";
            this.txt_tempat.Size = new System.Drawing.Size(70, 20);
            this.txt_tempat.TabIndex = 53;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_alamat.Location = new System.Drawing.Point(102, 172);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(171, 32);
            this.txt_alamat.TabIndex = 52;
            // 
            // txt_nik
            // 
            this.txt_nik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nik.Location = new System.Drawing.Point(102, 73);
            this.txt_nik.Name = "txt_nik";
            this.txt_nik.Size = new System.Drawing.Size(171, 20);
            this.txt_nik.TabIndex = 51;
            // 
            // txt_kk
            // 
            this.txt_kk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kk.Location = new System.Drawing.Point(102, 36);
            this.txt_kk.Name = "txt_kk";
            this.txt_kk.Size = new System.Drawing.Size(171, 20);
            this.txt_kk.TabIndex = 50;
            // 
            // txt_nama
            // 
            this.txt_nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nama.Location = new System.Drawing.Point(102, 6);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(171, 20);
            this.txt_nama.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 116);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.Location = new System.Drawing.Point(435, 181);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 70;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refresh.Location = new System.Drawing.Point(536, 181);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 71;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::FinPro_FORM_BPJS.Properties.Resources.pngtree_outline_user_icon_png_image_17279161;
            this.pictureBox1.Location = new System.Drawing.Point(290, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Cari Nama";
            // 
            // txt_cari
            // 
            this.txt_cari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cari.Location = new System.Drawing.Point(435, 140);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(90, 20);
            this.txt_cari.TabIndex = 73;
            // 
            // btn_cari
            // 
            this.btn_cari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cari.Location = new System.Drawing.Point(536, 138);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 72;
            this.btn_cari.Text = "Search";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cari);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_iuran);
            this.Controls.Add(this.cmb_pekerjaan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rd_perempuan);
            this.Controls.Add(this.rd_laki);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_tempat);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.txt_nik);
            this.Controls.Add(this.txt_kk);
            this.Controls.Add(this.txt_nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Update";
            this.Text = "Form_Update";
            this.Load += new System.EventHandler(this.Form_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_iuran;
        private System.Windows.Forms.ComboBox cmb_pekerjaan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rd_perempuan;
        private System.Windows.Forms.RadioButton rd_laki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_tempat;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.TextBox txt_nik;
        private System.Windows.Forms.TextBox txt_kk;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Button btn_cari;
    }
}