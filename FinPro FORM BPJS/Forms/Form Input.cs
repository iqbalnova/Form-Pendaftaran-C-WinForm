using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing.Imaging;

namespace FinPro_FORM_BPJS.Forms
{
    public partial class FormInput : Form
    {
        SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-9A8GVH2;Initial Catalog=FinPro_1;Integrated Security=True");
        public FormInput()
        {
            InitializeComponent();
        }
        string jenis_kel;
        string imglocation = "";
        string golongan; 
        SqlCommand cmd;

        private void FormInput_Load(object sender, EventArgs e)
        {
            cmb_pekerjaan.Items.Add("Mahasiswa/i");
            cmb_pekerjaan.Items.Add("Nelayan");
            cmb_pekerjaan.Items.Add("Petani");
            cmb_pekerjaan.Items.Add("Buruh Pabrik");
            cmb_iuran.Items.Add("< 1.000.000");
            cmb_iuran.Items.Add("1.000.000 - 2.000.000");
            cmb_iuran.Items.Add("> 2.000.000");
        }

        private void rd_laki_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kel = "Laki - Laki";
        }

        private void rd_perempuan_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kel = "Perempuan";
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-9A8GVH2;Initial Catalog=FinPro_1;Integrated Security=True");
            try
            {
             
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Data] (no_kk,no_nik,nama,jenis_kel,tempat_lahir,tgl_lahir,pekerjaan,alamat,iuran,golongan,foto) values ('" + txt_kk.Text + "', '" + txt_nik.Text + "', '" + txt_nama.Text + "', '" + jenis_kel + "', '" + txt_tempat.Text + "', '" + dateTimePicker1.Text + "', '" + cmb_pekerjaan.Text + "', '" + txt_alamat.Text + "', '" + cmb_iuran.Text + "', '" + golongan + "', @images) ";
               
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] images = stream.ToArray();
                cmd.Parameters.AddWithValue("@images", images);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Input Berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            
            
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
          
            Stream mystream = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((mystream = dialog.OpenFile()) != null)
                    {
                        String FileName = dialog.FileName;
                       
                        if (mystream.Length > 512000)
                        {
                            MessageBox.Show("File Terlalu Besar!");
                        }
                        else
                        {
                            pictureBox1.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
                 
        }

        private void cmb_iuran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_iuran.SelectedItem == "< 1.000.000")
            {
                golongan = "Golongan 1";
            }
            else if (cmb_iuran.SelectedItem == "1.000.000 - 2.000.000")
            {
                golongan = "Golongan 2";
            }
            else if (cmb_iuran.SelectedItem == "> 2.000.000")
            {
                golongan = "Golongan 3";
            }
        }
    }
}
