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
    public partial class FrmApplications : Form
    {
        public FrmApplications()
        {
            InitializeComponent();
        }
        connection connection = new connection();
        private void FrmApplications_Load(object sender, EventArgs e)
        {
            load_Data();
            
        }
        //METHODS - MANUALLY

        public void load_Data()
        {
            dgvApplications.Rows.Clear();
            SqlConnection conn = new SqlConnection(connection.str);
            string query = "SELECT * FROM tbl_budget";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[3].ToString(), row[2].ToString(), "0");
                }
            }
            catch
            {

            }
        }
        public void populate(string refID, string status, string dates, string description, string total)
        {
            dgvApplications.Rows.Add(refID, status, dates, description, total);
        }
    }
}
