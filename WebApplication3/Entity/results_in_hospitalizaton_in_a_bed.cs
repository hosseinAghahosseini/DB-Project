using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class results_in_hospitalizaton_in_a_bed
    {
        private int Bed_ID;
        private int Res_ID;

        public int Bed_ID1
        {
            get
            {
                return Bed_ID;
            }

            set
            {
                Bed_ID = value;
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
    }
}