namespace HotelConsoleAPP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BTest")]
    public partial class BTest
    {
        [Key]
        public int Booking_id { get; set; }

        public int Hotel_No { get; set; }

        public string name { get; set; }
    }
}
