using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelklasser
{
    public class Hotel
    {
        public int Hotel_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Hotel()
        {
            
        }

        public Hotel(int hotelNo, string name, string address)
        {
            Hotel_No = hotelNo;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Hotel_No: {Hotel_No}, Name: {Name}, Address: {Address}";
        }
    }
}
