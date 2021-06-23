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

namespace BudgetApproval
{
    public partial class frmLogin : Form
    {

        frmMenu frm = new frmMenu();
        public static string username = "";
        public frmLogin()
        {
            InitializeComponent();
            
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection connection = new connection();
            string uname = txtUname.Text;
            string password = txtPass.Text;
            try
            { 
                string query = "SELECT * FROM tbl_emp WHERE ID =@uname and password=@password";
                SqlConnection con = new SqlConnection(connection.str);
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("User : "+reader["name"]+" has successfully login", "Successfully Login...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    username = uname;
                    con.Close();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check username and password, then try again.","User Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Reset_Text();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        public void Reset_Text()
        {
            txtPass.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
