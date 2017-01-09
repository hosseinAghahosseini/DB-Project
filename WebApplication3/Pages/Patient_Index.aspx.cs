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
            SqlConnection con = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select  fName, lName,Expertise,SSN from Doctor ", con);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                //foreach ()
                string s = reader.GetString(0) + " " + reader.GetString(1) + " ( " + reader.GetString(2)+")";
                Doctor_name.Items.Insert(i, new ListItem(s));
                doctors_SSN[i] = reader.GetString(3);
                i++;
            }
            reader.Close();
            con.Close();
        }
        protected void Select_Doctor(object sender, EventArgs e)
        {
            int i = 0;
            string D_SSN = doctors_SSN[Doctor_name.SelectedIndex];
            SqlConnection con1 = new SqlConnection("Data Source=MRJ;Initial Catalog=Clinic2;Integrated Security=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select shift_des from timeShift where doc_ssn = '" + D_SSN +"'", con1);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                string t = reader.GetString(0);
                Choose_Time.Items.Insert(i, new ListItem(t));
                i++;
            }
            con1.Close();
        }
        
    }
}