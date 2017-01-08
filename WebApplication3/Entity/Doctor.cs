using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Doctor
    {
        private String SSN;
        private String fName;
        private String lName;
        private String Email;
        private int Loc_Number;
        private String Password_;

        public string SSN1
        {
            get
            {
                return SSN;
            }

            set
            {
                SSN = value;
            }
        }

        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public int Loc_Number1
        {
            get
            {
                return Loc_Number;
            }

            set
            {
                Loc_Number = value;
            }
        }

        public string Password_1
        {
            get
            {
                return Password_;
            }

            set
            {
                Password_ = value;
            }
        }
    }
}