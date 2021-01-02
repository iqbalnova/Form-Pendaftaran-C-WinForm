using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace FinPro_FORM_BPJS
{
    public partial class Home : Form
    {
        private Form activeForm;

        public Home()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_home.Text = childForm.Text;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            label_input.Visible = true;
            label_hasil.Visible = false;
            label_update.Visible = false;
            OpenChildForm(new Forms.FormInput(), sender);
        }

        private void btn_hsl_Click(object sender, EventArgs e)
        {
            label_input.Visible = false;
            label_hasil.Visible = true;
            label_update.Visible = false;
            OpenChildForm(new Forms.FormHasil(), sender);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            label_input.Visible = false;
            label_hasil.Visible = false;
            label_update.Visible = true;
            OpenChildForm(new Forms.Form_Update(), sender);
        }
    }
}
