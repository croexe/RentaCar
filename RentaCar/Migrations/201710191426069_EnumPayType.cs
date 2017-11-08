namespace RentaCar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnumPayType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rents", "PaymentType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rents", "PaymentType", c => c.Boolean(nullable: false));
        }
    }
}
