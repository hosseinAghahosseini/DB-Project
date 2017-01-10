using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Pages
{
    
    public partial class Patient_Index : System.Web.UI.Page
    {
        String[] doctors = new String[50];
        String[] doctors_SSN = new String[500];

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!Page.IsPostBack)
            //{ 
                if (CheckLoggedIn.p_user == null)
            {
                Response.Redirect("Log_In.aspx");
            }
            else { 
                Doctor_name.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select  fName, lName,Expertise,SSN from Doctor ", con);
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    string s = reader.GetString(0) + " " + reader.GetString(1) + " ( " + reader.GetString(2) + ")";
                    Doctor_name.Items.Insert(i, new ListItem(s));
                    doctors_SSN[i] = reader.GetString(3);
                    System.Diagnostics.Debug.WriteLine(doctors_SSN[i]);
                    i++;
                }
                reader.Close();
                con.Close();
                    //Doctor_name.SelectedIndex = lastIndex_Doctor;
                    //System.Diagnostics.Debug.WriteLine("2:" + lastIndex_Doctor);
                }
            //}
        }
        protected void Select_Doctor(object sender, EventArgs e)
        {

            Choose_Time.Items.Clear();
            int i = 0;
            string D_SSN = doctors_SSN[Doctor_name.SelectedIndex];
            int x = Doctor_name.SelectedIndex;
            //System.Diagnostics.Debug.WriteLine("OK"+x);
            SqlConnection con1 = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select shift_des,Date_ from timeShift where doc_ssn = '" + D_SSN +"'", con1);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                string t = reader.GetDateTime(1).ToShortDateString().ToString() + " - " + reader.GetString(0);
                Choose_Time.Items.Insert(i, new ListItem(t));
                i++;
            }
            reader.Close();
            con1.Close();
            //lastIndex_Doctor = Doctor_name.SelectedIndex;
            //System.Diagnostics.Debug.WriteLine("1:" + lastIndex_Doctor);
        }

        protected void abc(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("11111111111");
        }


    }
}