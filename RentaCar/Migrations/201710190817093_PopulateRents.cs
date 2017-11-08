namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRents : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name, RentId) VALUES('Petar Popovic', 1)");
            Sql("INSERT INTO Customers(Name, RentId) VALUES('Dmitar Zvonimir', 2)");
            Sql("INSERT INTO Customers(Name, RentId) VALUES('Josip Mustaè', 3)");
        }

        public override void Down()
        {
        }
    }
}
