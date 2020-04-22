using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using ControllerKlasser;
using Hotelklasser;

namespace ObligatoriskOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel =new Hotel(8, "Jeg er en test", "testvej 1");
           
            //new ManageHotel().Create(hotel);
            //Console.WriteLine(new ManageHotel().GetFromId(8));
            //hotel.Address = "NY testvej 1";
            //new ManageHotel().Update(hotel, 8);
            //Console.WriteLine(new ManageHotel().GetFromId(8));
            new ManageHotel().Delete(8);

           // List<Hotel> list = new ManageHotel().GetAll();

            //foreach (var ho in list)
            {
                //Console.WriteLine(ho);
            }


            Facility facility = new Facility(9, "Dart", "Sport");

            //new ManageFacility().Create(facility);
            //Console.WriteLine(new ManageFacility().GetFromId(9));
            //facility.Type = "Aktivitet";
            //new ManageFacility().Update(facility, 9);
            //Console.WriteLine(new ManageFacility().GetFromId(9));
            //new ManageFacility().Delete(9);

            //List<Facility> fList = new ManageFacility().GetAll();
            //foreach (var fac in fList)
            {
                //Console.WriteLine(fac);
            }
        }
    }
}
