using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class prescription
    {
        private int pre_iD;
        private int Res_ID;
        private string pre_discription;

        public int Pre_iD
        {
            get
            {
                return pre_iD;
            }

            set
            {
                pre_iD = value;
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

        public string Pre_discription
        {
            get
            {
                return pre_discription;
            }

            set
            {
                pre_discription = value;
            }
        }
    }
}