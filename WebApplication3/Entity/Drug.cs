using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class Drug
    {
        private int Drug_id;
        private String Drug_name;
        private String Drug_description;
        private String Use_method;

        public int Drug_id1
        {
            get
            {
                return Drug_id;
            }

            set
            {
                Drug_id = value;
            }
        }

        public string Drug_name1
        {
            get
            {
                return Drug_name;
            }

            set
            {
                Drug_name = value;
            }
        }

        public string Drug_description1
        {
            get
            {
                return Drug_description;
            }

            set
            {
                Drug_description = value;
            }
        }

        public string Use_method1
        {
            get
            {
                return Use_method;
            }

            set
            {
                Use_method = value;
            }
        }
    }
}