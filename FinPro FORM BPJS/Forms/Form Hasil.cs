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

namespace FinPro_FORM_BPJS.Forms
{
    public partial class FormHasil : Form
    {
        SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-9A8GVH2;Initial Catalog=FinPro_1;Integrated Security=True");
        public FormHasil()
        {
            InitializeComponent();
            tampil();
        }
        SqlCommand cmd;

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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Data] where nama LIKE '%"+txt_cari.Text+"%' ";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_cari.Text = row.Cells["nama"].Value.ToString();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Data] where nama='" + txt_cari.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
            MessageBox.Show("Hapus Berhasil!");
        }
    }
}
