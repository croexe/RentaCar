namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            AlterColumn("dbo.Rents", "UserType", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rents", "UserType", c => c.String());
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
