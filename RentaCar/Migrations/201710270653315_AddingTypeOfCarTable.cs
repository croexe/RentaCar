namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTypeOfCarTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypeOfCars",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "TypeOfCar_Id", c => c.Byte());
            CreateIndex("dbo.Cars", "TypeOfCar_Id");
            AddForeignKey("dbo.Cars", "TypeOfCar_Id", "dbo.TypeOfCars", "Id");
            DropColumn("dbo.Cars", "TypeOfCar");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "TypeOfCar", c => c.String());
            DropForeignKey("dbo.Cars", "TypeOfCar_Id", "dbo.TypeOfCars");
            DropIndex("dbo.Cars", new[] { "TypeOfCar_Id" });
            DropColumn("dbo.Cars", "TypeOfCar_Id");
            DropTable("dbo.TypeOfCars");
        }
    }
}
