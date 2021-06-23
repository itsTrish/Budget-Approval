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
namespace BudgetApproval
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        public OpenFileDialog open1 = new OpenFileDialog();
        class_budget budget = new class_budget();
        connection connection = new connection();
        
        string date = DateTime.Now.Date.ToString().Substring(8, 2);
        string path = "", Filename = "";
        private void frmForm_Load(object sender, EventArgs e)
        {
            string timestamp = DateTime.UtcNow.ToString("dHH:mm:ss.fff");
            timestamp = timestamp.Replace(":", "");
            timestamp = timestamp.Replace(".", "");
            label_Ref.Text = date+timestamp;
            string query = "SELECT * FROM tbl_emp WHERE position = 'DEPARTMENT HEAD'";
            SqlConnection conn = new SqlConnection(connection.str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbDept.Items.Add(reader["name"]);
            }
        }

        private void frmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Root = @"" + "\\\\172.17.1.77\\budget_approval\\FILES" + '\\'+ label_Ref.Text;
            if (!Directory.Exists(Root))
            {
                Directory.CreateDirectory(Root);
            }
            Filename = "Document";
            string filePath = Root + "\\" + Filename;
            File.Copy(path, filePath);
            string budgetPeriod = cmbPeriod.Text;
            string currency = cmbCurrency.Text;
            string outline = txtOutline.Text;
            string purpose = txtPurpose.Text;
            string roi = txtROI.Text;
            string deptHead_ID = cmbDept.Text;
            string request_description = txtItem.Text;
            string date_filed = DateTime.Now.ToString("dd/MM/yy");

            string insert_data = String.Format("INSERT INTO tbl_budget(ref_ID,status,request_description,date_filed,budgetPeriod,currency,quotation,image,roi,outline,purpose,item_ID,deptHead_ID) VALUES(@ref_ID,@status,@request_description,@date_filed,@budgetPeriod,@currency,@quotation,@image,@roi,@outline,@purpose,@item_ID,@deptHead_ID)");
            SqlConnection conn = new SqlConnection(connection.str);
            SqlCommand cmd = new SqlCommand(insert_data, conn);
            cmd.Parameters.AddWithValue("@ref_ID", label_Ref.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@request_description", request_description);
            cmd.Parameters.AddWithValue("@budgetPeriod", budgetPeriod);
            cmd.Parameters.AddWithValue("@currency", currency);
            cmd.Parameters.AddWithValue("@quotation", filePath);
            cmd.Parameters.AddWithValue("@date_filed", date_filed);
            cmd.Parameters.AddWithValue("@image", currency);
            cmd.Parameters.AddWithValue("@outline",outline);
            cmd.Parameters.AddWithValue("@purpose", purpose);
            cmd.Parameters.AddWithValue("@roi", roi);
            cmd.Parameters.AddWithValue("@item_ID", label_Ref.Text);
            cmd.Parameters.AddWithValue("@deptHead_ID", deptHead_ID);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            try
            {
                if (i > 0)
                {
                    MessageBox.Show(i + " Data Saved");
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void Reset()
        {
            txtROI.ResetText();
            txtPurpose.ResetText();
            txtOutline.ResetText();
            txtItem.ResetText();
            cmbCurrency.ResetText();
            cmbDept.ResetText();
            cmbPeriod.ResetText();
            string timestamp = DateTime.UtcNow.ToString("dHH:mm:ss.fff");
            timestamp = timestamp.Replace(":", "");
            timestamp = timestamp.Replace(".", "");
            label_Ref.Text = date + timestamp;
            lbl_path1.Text = "directory path...";
            lbl_path2.Text = "directory path...";
        }
        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            panelSubmit.BackColor = ColorTranslator.FromHtml("#5C99C8");
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            panelSubmit.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            open1.Filter = "Document FILES (*.xlsx,*.doc,*.doxc)|*.xlsx,*.doc,*.doxc|PDF FILES (*.pdf)|*.pdf|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            open1.FilterIndex = 2;
            
            DialogResult result = open1.ShowDialog();
            open1.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                path = open1.FileName;
                lbl_path1.Text = path;
            }
        }
    }
}
