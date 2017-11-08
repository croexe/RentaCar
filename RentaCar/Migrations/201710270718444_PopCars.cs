namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopCars : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cars(Name, TypeOfCar_Id, YearOfManufacture, DateAddedToDatabase, NumberInStock) VALUES('Honda Civic', 2, CAST('2010-07-12' AS DATETIME), CAST('2015-08-03' AS DATETIME), 2)");
            Sql("INSERT INTO Cars(Name, TypeOfCar_Id, YearOfManufacture, DateAddedToDatabase, NumberInStock) VALUES('BMW V6', 3, CAST('2016-08-28' AS DATETIME), CAST('2017-09-10' AS DATETIME), 10)");
            Sql("INSERT INTO Cars(Name, TypeOfCar_Id, YearOfManufacture, DateAddedToDatabase, NumberInStock) VALUES('Škoda Octavia', 2, CAST('2014-03-01' AS DATETIME), CAST('2014-04-27' AS DATETIME), 5)");
            Sql("INSERT INTO Cars(Name, TypeOfCar_Id, YearOfManufacture, DateAddedToDatabase, NumberInStock) VALUES('Renault Clio', 1, CAST('2007-03-05' AS DATETIME), CAST('2012-05-01' AS DATETIME), 9)");
        }
        
        public override void Down()
        {
        }
    }
}
