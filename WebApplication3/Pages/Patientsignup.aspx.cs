using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication3
{
    public partial class Patientsignup : System.Web.UI.Page
    {
        string Fname;
        string Lname;
        string ssn;
        string mail;
        string pass;
        protected void Page_Load(object sender, EventArgs e)
        {
            Fname = PatientFName.Text;
            Lname = PatientLname.Text;
            ssn = pSSN.Text;
            mail = pEmail.Text;
            pass = ppassword.Text;
        }
        protected void PatientSubmit(Object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO patient(SSN,fName,lName,email,password_) VALUES('" + ssn + "','" + Lname + "','" + Fname + "','" + mail + "','" + pass + "');", con);
            cmd.ExecuteScalar();
            con.Close();
        }

    }
}