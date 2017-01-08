using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class timeshift
    {
        private int TS_ID;
        private String Date_;
        private String Start_Time;
        private String End_Time;

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

        public string Date_1
        {
            get
            {
                return Date_;
            }

            set
            {
                Date_ = value;
            }
        }

        public string Start_Time1
        {
            get
            {
                return Start_Time;
            }

            set
            {
                Start_Time = value;
            }
        }

        public string End_Time1
        {
            get
            {
                return End_Time;
            }

            set
            {
                End_Time = value;
            }
        }
    }
}