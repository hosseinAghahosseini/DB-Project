using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class doctor_attends_timeshift
    {
        private int Doctor_SSN;
        private int TimeShift_ID;

        public int Doctor_SSN1
        {
            get
            {
                return Doctor_SSN;
            }

            set
            {
                Doctor_SSN = value;
            }
        }

        public int TimeShift_ID1
        {
            get
            {
                return TimeShift_ID;
            }

            set
            {
                TimeShift_ID = value;
            }
        }
    }
}