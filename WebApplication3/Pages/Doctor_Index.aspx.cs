using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Doctor_Login : System.Web.UI.Page
    {
        string timeshift;
        string doc_ssn;
        string date_TS;
        string discription;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(CheckLoggedIn.username == null)
            {
                Response.Redirect("Log_In.aspx");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select ssn from doctor where email = '" + CheckLoggedIn.username + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doc_ssn = (string)reader["ssn"];
                }
                
                con.Close();
            }
        }
        protected void AddTimeShift(object sender, EventArgs e)
        {
            timeshift = shift.SelectedValue;
            date_TS = _Date.Text.ToString();
            discription = shift.SelectedItem.Text;
            SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from timeShift where Date_ = '" + date_TS + "' and shift_no = '" + timeshift + "' and doc_ssn = '" + doc_ssn + "'", con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            if (!reader1.HasRows) {
                reader1.Close();
            SqlCommand cmd = new SqlCommand("insert into timeShift(Date_, shift_no,shift_des,doc_ssn) values('"+ date_TS+"', '"+ timeshift+"','"+ discription +"', '"+doc_ssn+"'); ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            }
            else
            {
                Response.Redirect("Log_In.aspx");
            }
        }
    }
}