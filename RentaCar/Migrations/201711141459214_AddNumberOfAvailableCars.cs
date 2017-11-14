namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberOfAvailableCars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "NumberAvailable", c => c.Byte(nullable: false));
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime());

            Sql("UPDATE Cars SET NumberAvailable=NumberInStock");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rentals", "DateReturned", c => c.DateTime(nullable: false));
            DropColumn("dbo.Cars", "NumberAvailable");
        }
    }
}
