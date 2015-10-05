namespace HotelConsoleAPP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hotel", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hotel", "Rating");
        }
    }
}
