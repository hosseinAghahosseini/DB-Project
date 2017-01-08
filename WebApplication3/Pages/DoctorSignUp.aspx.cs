using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string Fname;
        string Lname;
        string Doc_ssn;
        string mail;
        string loc;
        string pass;
        protected void Page_Load(object sender, EventArgs e)
        {
            Fname = DoctorFName.Text;
            Lname =  DoctorLname.Text;
            Doc_ssn =  SSN.Text;
            mail =  Email.Text;
            loc = location.Text;
            pass = password.Text;
        }
        protected void DoctorSubmit(Object sender,EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO doctor(SSN,fName,lName,email,Loc_Number,password_) VALUES('" + Doc_ssn + "','" + Lname + "','" + Fname + "','" + mail + "','" + loc + "','" + pass + "');", con);
            cmd.ExecuteScalar();
            con.Close();
        }
    }
}