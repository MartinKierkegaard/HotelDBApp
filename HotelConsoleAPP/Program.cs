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

                //List<Room> legolandRooms = new List<Room>()
                //{
                //    new Room() {Hotel_No = 400,Room_No = 1,Price = 500,Types = "D"},
                //    new Room() {Hotel_No = 400,Room_No = 2,Price = 300,Types = "S"},
                //    new Room() {Hotel_No = 400,Room_No = 3,Price = 500,Types = "D"},
                //    new Room() {Hotel_No = 400,Room_No = 4,Price = 800,Types = "F"},
                //};  

                //var MyNewHotel = new Hotel()
                //{
                //    Name = "LegoLand Hotel",
                //    Hotel_No = 400,
                //    Address = "Legoland gade 1",
                //    Room = legolandRooms
                //};

                // db.Hotel.Add(MyNewHotel);

                // db.SaveChanges();

                //var legolandList = from h in db.Hotel
                //    join r in db.Room
                //        on h.Hotel_No equals r.Hotel_No
                //    where h.Hotel_No == 400
                //    select new  {hotelname = h.Name ,r.Room_No, r.Types, r.Price  } 
                //;

                //foreach (var l in legolandList)
                //{
                //    Console.WriteLine(l.ToString());
                //}

                //var guestList = from g in db.Guest
                //    select new  {g.Name,g.GuestRating};

                //foreach (var g in guestList)
                //{
                //    Console.WriteLine(g.ToString());
                //}

                //var hotellist = from hotel in db.Hotel
                //                where hotel.HotelUrl != null
                //    select new {Name = hotel.Name, Url = (hotel.HotelUrl)?? " No website found "};


                //foreach (var h in hotellist)
                //{
                //    Console.Write(h.Name);
                //    Console.WriteLine(" The web url is :" + h.Url);
                //}

                //var guestList = from g in db.Guest
                //                select g;

                //foreach (var guest in guestList)
                //{
                //    var Guest = new Guest();
                //    Guest = guest;

                //    Console.Write(Guest.ToString() );
                //}


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
