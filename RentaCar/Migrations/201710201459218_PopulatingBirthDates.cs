namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingBirthDates : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1988-08-08' AS DATETIME) WHERE Id = 6");
        }
        
        public override void Down()
        {
        }
    }
}
