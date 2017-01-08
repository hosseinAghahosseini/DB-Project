using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Patient
    {
        private int Pat_ID;
        private String SSN;
        private String fName;
        private String lName;
        private String Email;
        private String Password_;

        public int Pat_ID1
        {
            get
            {
                return Pat_ID;
            }

            set
            {
                Pat_ID = value;
            }
        }

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