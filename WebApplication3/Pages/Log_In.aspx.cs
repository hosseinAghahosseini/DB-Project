using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Log_In : System.Web.UI.Page
    {
        string user;
        string d_pass;

        string P_user;
        string P_pass;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = D_Username1.Text;
            d_pass = D_Password1.Text;

            P_user = P_username1.Text;
            P_pass = P_Password1.Text;
                      
        }
        protected void DoctorLogin(object sender,EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from doctor where email = '"+ user + "'and password_ = '" + d_pass + "'", con);
            SqlDataReader reader =  cmd.ExecuteReader();
            if (reader.HasRows)
            {
                CheckLoggedIn.username = user;
                CheckLoggedIn.password = d_pass;
                Response.Redirect("Doctor_Index.aspx");
            }
            else
            {
                Response.Redirect("Log_In.aspx");
            }
            con.Close();
        }
        protected void PatientLogin(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from patient where email = '" + P_user + "'and password_ = '" + P_pass + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                CheckLoggedIn.p_user = P_user;
                CheckLoggedIn.p_pass = P_pass;
                Response.Redirect("Patient_Index.aspx");
            }
            else
            {
                Response.Redirect("Log_In.aspx");
            }
            con.Close();
        }


    }
}