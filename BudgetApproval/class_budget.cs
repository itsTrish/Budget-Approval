using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BudgetApproval
{
    class class_budget
    {
        public string str = "server=maindbase;database=eformsdb;UID=sa;password=admin123";
        public string employee_number = "";
        public string name = "";
        public string ref_ID = "";
        public string department = "";
        public string position = "";
        public string email_Add = "";
        public string get_Name(string emp_id)
        {
            string query = "SELECT * FROM tbl_emp WHERE ID=@emp_id";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@emp_id", emp_id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader["name"].ToString();
            }
            else
            {
                name = "ERROR";
            }
            return name;
        }
    }
}