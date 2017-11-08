namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCars2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cars(Name, YearOfManufacture, DateAddedToDatabase, NumberInStock, TypeOfCar_Id) VALUES('Škoda Octavia', CAST('2010-05-28' AS DATETIME), CAST('2011-03-16' AS DATETIME), 12, 2)");
            Sql("INSERT INTO Cars(Name, YearOfManufacture, DateAddedToDatabase, NumberInStock, TypeOfCar_Id) VALUES('Renault Clio', CAST('2007-03-05' AS DATETIME), CAST('2012-05-01' AS DATETIME), 9, 1)");
            Sql("INSERT INTO Cars(Name, YearOfManufacture, DateAddedToDatabase, NumberInStock, TypeOfCar_Id) VALUES('BMW V8', CAST('2013-02-07' AS DATETIME), CAST('2013-01-13' AS DATETIME), 3, 4)");

        }

        public override void Down()
        {
        }
    }
}
