using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelklasser
{
    public class Facility
    {
        public int Facility_Id { get; set; }
        public string Facility_Name { get; set; }
        public string Type { get; set; }

        public Facility()
        {
            
        }

        public Facility(int facilityId, string facilityName, string type)
        {
            Facility_Id = facilityId;
            Facility_Name = facilityName;
            Type = type;
        }

        public override string ToString()
        {
            return $"Facility_Id: {Facility_Id}, Facility_Name: {Facility_Name}, Type: {Type}";
        }
    }
}
