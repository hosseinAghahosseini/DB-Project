using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class ExperimentResult
    {
        private int Exp_ID;
        private int Res_Id;
        private String ExpDescription;

        public int Exp_ID1
        {
            get
            {
                return Exp_ID;
            }

            set
            {
                Exp_ID = value;
            }
        }

        public int Res_Id1
        {
            get
            {
                return Res_Id;
            }

            set
            {
                Res_Id = value;
            }
        }

        public string ExpDescription1
        {
            get
            {
                return ExpDescription;
            }

            set
            {
                ExpDescription = value;
            }
        }
    }
}