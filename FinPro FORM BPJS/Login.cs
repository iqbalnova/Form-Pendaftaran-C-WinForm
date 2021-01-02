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

namespace FinPro_FORM_BPJS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
                txt_pass.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection("Data Source=DESKTOP-9A8GVH2;Initial Catalog=FinPro_1;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login where username='" + txt_user.Text + "' AND password='" + txt_pass.Text + "'",koneksi );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home panggil = new Home();
                panggil.Show();
            }
            else
                MessageBox.Show("Mohon isi Username dan Password anda dengan benar","Perhatian ",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
