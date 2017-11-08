namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTypeOfCar : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TypeOfCars(Id, Type) VALUES(1, 'Mini')");
            Sql("INSERT INTO TypeOfCars(Id, Type) VALUES(2, 'Limusina')");
            Sql("INSERT INTO TypeOfCars(Id, Type) VALUES(3, 'Monovolumen')");
            Sql("INSERT INTO TypeOfCars(Id, Type) VALUES(4, 'Jeep')");
        }
        
        public override void Down()
        {
        }
    }
}
