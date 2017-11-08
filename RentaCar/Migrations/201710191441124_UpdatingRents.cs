namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingRents : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Rents SET UserType = 'Annual Customer' WHERE Id=1 ");
            Sql("UPDATE dbo.Rents SET UserType = 'Regular Customer' WHERE Id=2 ");
            Sql("UPDATE dbo.Rents SET UserType = 'Daily Customer' WHERE Id=3 ");
            
        }
        
        public override void Down()
        {
        }
    }
}
