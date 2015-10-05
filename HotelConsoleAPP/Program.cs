using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelConsoleAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new HotelContext())
            {

                var MynewHotel = new Hotel() {
                    Name = "LegoLand Hotel"
                    ,Hotel_No = 100,
                    Address = "Legoland gade 1",
               };

                db.Hotel.Add(MynewHotel);

                db.SaveChanges();

                var hotellist = from hotel in db.Hotel
                                select hotel;

                foreach (var h in hotellist)
                {
                    Console.WriteLine(h.Name);
                }




                //var myNewHotel = new Hotel()
                //{
                //    Name = "MartinsHotel",
                //    Address = "HotelVej 1",
                //    Hotel_No = 11,
                //};

                //var mynewBooking = new Booking()
                //{

                //};

                //var mynewGuest = new Guest()
                //{
                //    Name = "Luke SkyWalker",
                //    Address = "DeathStar 1",
                //    Guest_No = 55
                //};
                //db.Guest.Add(mynewGuest);
                ////db.Hotel.Add(myNewHotel);
                //db.SaveChanges();

                //var hotellist = from hotel in db.Hotel
                //    select hotel;

                //foreach (var h in hotellist)
                //{
                //    Console.WriteLine(h.Name);
                //}

                Console.ReadLine();
            }

        }
    }
}
