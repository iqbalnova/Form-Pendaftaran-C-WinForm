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
using System.IO;
using System.Drawing.Imaging;

namespace FinPro_FORM_BPJS.Forms
{
    public partial class Form_Update : Form
    {
        SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-9A8GVH2;Initial Catalog=FinPro_1;Integrated Security=True");
        public Form_Update()
        {
            InitializeComponent();
            tampil();
        }
        string jenis_kel;
        string imglocation = "";
        string golongan;
        SqlCommand cmd;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_cari.Text = row.Cells["nama"].Value.ToString();
                txt_alamat.Text = row.Cells["alamat"].Value.ToString();
                txt_kk.Text = row.Cells["no_kk"].Value.ToString();
                txt_nik.Text = row.Cells["no_nik"].Value.ToString();
                txt_nama.Text = row.Cells["nama"].Value.ToString();
                txt_tempat.Text = row.Cells["tempat_lahir"].Value.ToString();
                cmb_iuran.Text = row.Cells["iuran"].Value.ToString();
                cmb_pekerjaan.Text = row.Cells["pekerjaan"].Value.ToString();

                if (row.Cells["jenis_kel"].Value.ToString() == "Laki - Laki") 
                {
                    rd_laki.Checked = true;
                }
                else if (row.Cells["jenis_kel"].Value.ToString() == "Perempuan") 
                {
                    rd_perempuan.Checked = true;
                }


                txt_nama.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                byte[] imgData = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
                MemoryStream ms = new MemoryStream(imgData);
                pictureBox1.Image = Image.FromStream(ms);
                
           
        }

        void tampil()
        {
            SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-9A8GVH2;Initial Catalog=FinPro_1;Integrated Security=True");
            try
            {
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Data]";
                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dta);
                dataGridView1.DataSource = dta;
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-9A8GVH2;Initial Catalog=FinPro_1;Integrated Security=True");
            try
            {
                byte[] images = null;
                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);
                koneksi.Open();
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Data SET no_kk='" + txt_kk.Text + "', no_nik='" + txt_nik.Text + "', nama='" + txt_nama.Text + "', jenis_kel='" + jenis_kel + "', tempat_lahir='" + txt_tempat.Text + "', tgl_lahir='" + dateTimePicker1.Text + "', pekerjaan='" + cmb_pekerjaan.Text + "', alamat='" + txt_alamat.Text + "', iuran='" + cmb_iuran.Text + "', golongan='" + golongan + "', foto=@images where nama='" + txt_nama.Text + "' ";
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Update Berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            tampil();
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

        private void rd_perempuan_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kel = "Perempuan";
        }

        private void rd_laki_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kel = "Laki - Laki";
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
            cmb_pekerjaan.Items.Add("Mahasiswa/i");
            cmb_pekerjaan.Items.Add("Nelayan");
            cmb_pekerjaan.Items.Add("Petani");
            cmb_pekerjaan.Items.Add("Buruh Pabrik");
            cmb_iuran.Items.Add("< 1.000.000");
            cmb_iuran.Items.Add("1.000.000 - 2.000.000");
            cmb_iuran.Items.Add("> 2.000.000");
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Data] where nama LIKE '%" + txt_cari.Text + "%' ";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }
    }
}
