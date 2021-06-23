using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApproval
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public bool active_form = false, active_applications=false;
        class_User user_class = new class_User();
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            btnUser.Text = user_class.get_Name(frmLogin.username);
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            frmForm applicationform = new frmForm();
            applicationform.MdiParent = this;
            active_form = true;
            if (active_form == true)
            {
                btnForm.Enabled = false;
                btnForm.BackColor = ColorTranslator.FromHtml("#5C99C8");
            }
            applicationform.Show();
        }
        public void Refresh_Page()
        {

            if (ActiveMdiChild == null || ActiveMdiChild.Name != "frmForm")
            {
                btnForm.Enabled = true;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                btnForm.Enabled = true;
                btnApplicationList.Enabled = true;
                btnUser.Enabled = true;
                btnForm.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                btnApplicationList.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                btnDashboard.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                btnUser.BackColor = ColorTranslator.FromHtml("#F5F5F5");
            }
            else if (ActiveMdiChild.Name != "frmForm")
            {
                btnForm.Enabled = true;
                btnForm.BackColor = ColorTranslator.FromHtml("#F5F5F5");
            }
            else if (ActiveMdiChild.Name != "frmApplications")
            {
                btnApplicationList.Enabled = true;
                btnApplicationList.BackColor = ColorTranslator.FromHtml("#F5F5F5");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Dispose();
            this.Close();
        }

        private void btnApplicationList_Click(object sender, EventArgs e)
        {
            FrmApplications frmApplications = new FrmApplications();
            active_applications = true;
            frmApplications.MdiParent = this;
            if (active_applications == true)
            {
                btnApplicationList.Enabled = false;
                btnApplicationList.BackColor = ColorTranslator.FromHtml("#5C99C8");
            }
            frmApplications.Show();

        }
    }
}
