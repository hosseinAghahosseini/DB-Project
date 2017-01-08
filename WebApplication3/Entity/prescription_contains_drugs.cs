using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class prescription_contains_drugs
    {
        private int pre_ID;
        private int Drug_Id;

        public int Pre_ID
        {
            get
            {
                return pre_ID;
            }

            set
            {
                pre_ID = value;
            }
        }

        public int Drug_Id1
        {
            get
            {
                return Drug_Id;
            }

            set
            {
                Drug_Id = value;
            }
        }
    }
}