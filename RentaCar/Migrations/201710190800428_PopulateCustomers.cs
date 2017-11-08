namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Rents(Id, PaymentType, Fee, DurationInWeeks, DiscountRate ) VALUES(1, 1, 12500, 16, 15)");
            Sql("INSERT INTO Rents(Id, PaymentType, Fee, DurationInWeeks, DiscountRate ) VALUES(2, 1, 3750, 1, 0)");
            Sql("INSERT INTO Rents(Id, PaymentType, Fee, DurationInWeeks, DiscountRate ) VALUES(3, 0, 17000, 19, 25)");
            
        }
        
        public override void Down()
        {
        }
    }
}
