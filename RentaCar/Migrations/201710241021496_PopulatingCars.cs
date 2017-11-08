namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCars : DbMigration
    {
        public override void Up()
        {
             Sql("INSERT INTO Cars(Name, TypeOfCar, YearOfManufacture, DateAddedToDatabase, NumberInStock) VALUES('Renault Clio', 'Mini', CAST('2007-03-05' AS DATETIME), CAST('2012-05-01' AS DATETIME), 9)");
            
        }
        
        public override void Down()
        {
        }
    }
}
