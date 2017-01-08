using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class surgery
    {
        private int Sur_ID;
        private String Doc_SSN;
        private int Res_ID;
        private int Pat_ID;
        private String Sur_Date;
        private String Sur_Description;

        public int Sur_ID1
        {
            get
            {
                return Sur_ID;
            }

            set
            {
                Sur_ID = value;
            }
        }

        public string Doc_SSN1
        {
            get
            {
                return Doc_SSN;
            }

            set
            {
                Doc_SSN = value;
            }
        }

        public int Res_ID1
        {
            get
            {
                return Res_ID;
            }

            set
            {
                Res_ID = value;
            }
        }

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

        public string Sur_Date1
        {
            get
            {
                return Sur_Date;
            }

            set
            {
                Sur_Date = value;
            }
        }

        public string Sur_Description1
        {
            get
            {
                return Sur_Description;
            }

            set
            {
                Sur_Description = value;
            }
        }
    }
}