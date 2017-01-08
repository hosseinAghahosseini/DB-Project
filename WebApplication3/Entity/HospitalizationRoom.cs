using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Entity
{
    public class HospitalizationRoom
    {
        private int Room_Id;
        private string RoomFeatures;

        public int Room_Id1
        {
            get
            {
                return Room_Id;
            }

            set
            {
                Room_Id = value;
            }
        }

        public string RoomFeatures1
        {
            get
            {
                return RoomFeatures;
            }

            set
            {
                RoomFeatures = value;
            }
        }
    }
}