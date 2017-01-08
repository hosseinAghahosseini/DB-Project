using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class appointment
    {
        private int App_ID;
        private int Pat_ID;
        private String Doc_SSN;
        private int TS_ID;

        public int TS_ID1
        {
            get
            {
                return TS_ID;
            }

            set
            {
                TS_ID = value;
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

        public int App_ID1
        {
            get
            {
                return App_ID;
            }

            set
            {
                App_ID = value;
            }
        }
    }
}