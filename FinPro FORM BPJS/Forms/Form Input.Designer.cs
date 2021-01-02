namespace FinPro_FORM_BPJS.Forms
{
    partial class FormInput
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
            this.btn_input = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Pekerjaan";
            // 
            // cmb_iuran
            // 
            this.cmb_iuran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_iuran.FormattingEnabled = true;
            this.cmb_iuran.Location = new System.Drawing.Point(117, 257);
            this.cmb_iuran.Name = "cmb_iuran";
            this.cmb_iuran.Size = new System.Drawing.Size(121, 21);
            this.cmb_iuran.TabIndex = 47;
            this.cmb_iuran.SelectedIndexChanged += new System.EventHandler(this.cmb_iuran_SelectedIndexChanged);
            // 
            // cmb_pekerjaan
            // 
            this.cmb_pekerjaan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_pekerjaan.FormattingEnabled = true;
            this.cmb_pekerjaan.Location = new System.Drawing.Point(117, 230);
            this.cmb_pekerjaan.Name = "cmb_pekerjaan";
            this.cmb_pekerjaan.Size = new System.Drawing.Size(121, 21);
            this.cmb_pekerjaan.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Iuran";
            // 
            // btn_upload
            // 
            this.btn_upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_upload.Location = new System.Drawing.Point(341, 210);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(144, 30);
            this.btn_upload.TabIndex = 44;
            this.btn_upload.Text = "BROWSE";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // rd_perempuan
            // 
            this.rd_perempuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rd_perempuan.AutoSize = true;
            this.rd_perempuan.Location = new System.Drawing.Point(199, 154);
            this.rd_perempuan.Name = "rd_perempuan";
            this.rd_perempuan.Size = new System.Drawing.Size(79, 17);
            this.rd_perempuan.TabIndex = 42;
            this.rd_perempuan.TabStop = true;
            this.rd_perempuan.Text = "Perempuan";
            this.rd_perempuan.UseVisualStyleBackColor = true;
            this.rd_perempuan.CheckedChanged += new System.EventHandler(this.rd_perempuan_CheckedChanged);
            // 
            // rd_laki
            // 
            this.rd_laki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rd_laki.AutoSize = true;
            this.rd_laki.Location = new System.Drawing.Point(117, 154);
            this.rd_laki.Name = "rd_laki";
            this.rd_laki.Size = new System.Drawing.Size(70, 17);
            this.rd_laki.TabIndex = 41;
            this.rd_laki.TabStop = true;
            this.rd_laki.Text = "Laki - laki";
            this.rd_laki.UseVisualStyleBackColor = true;
            this.rd_laki.CheckedChanged += new System.EventHandler(this.rd_laki_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tempat, Tgl Lahir";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "No. NIK";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "No. KK";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nama";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // txt_tempat
            // 
            this.txt_tempat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tempat.Location = new System.Drawing.Point(117, 119);
            this.txt_tempat.Name = "txt_tempat";
            this.txt_tempat.Size = new System.Drawing.Size(75, 20);
            this.txt_tempat.TabIndex = 33;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_alamat.Location = new System.Drawing.Point(117, 185);
            this.txt_alamat.Multiline = true;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(195, 36);
            this.txt_alamat.TabIndex = 32;
            // 
            // txt_nik
            // 
            this.txt_nik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nik.Location = new System.Drawing.Point(117, 86);
            this.txt_nik.Name = "txt_nik";
            this.txt_nik.Size = new System.Drawing.Size(195, 20);
            this.txt_nik.TabIndex = 31;
            // 
            // txt_kk
            // 
            this.txt_kk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_kk.Location = new System.Drawing.Point(117, 49);
            this.txt_kk.Name = "txt_kk";
            this.txt_kk.Size = new System.Drawing.Size(195, 20);
            this.txt_kk.TabIndex = 30;
            // 
            // txt_nama
            // 
            this.txt_nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nama.Location = new System.Drawing.Point(117, 19);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(195, 20);
            this.txt_nama.TabIndex = 29;
            // 
            // btn_input
            // 
            this.btn_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_input.Location = new System.Drawing.Point(489, 277);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 23);
            this.btn_input.TabIndex = 49;
            this.btn_input.Text = "INPUT";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::FinPro_FORM_BPJS.Properties.Resources.pngtree_outline_user_icon_png_image_17279161;
            this.pictureBox1.Location = new System.Drawing.Point(342, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.btn_input);
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
            this.Name = "FormInput";
            this.Text = "FormInput";
            this.Load += new System.EventHandler(this.FormInput_Load);
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
        private System.Windows.Forms.Button btn_input;
    }
}