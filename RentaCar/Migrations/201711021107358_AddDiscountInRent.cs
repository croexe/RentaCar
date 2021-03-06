namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiscountInRent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rents", "Discount", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Rents", "Discount");
        }
    }
}
