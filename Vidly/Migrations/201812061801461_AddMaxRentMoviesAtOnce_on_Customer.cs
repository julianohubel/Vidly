namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaxRentMoviesAtOnce_on_Customer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MaxRentMoviesAtOnce", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MaxRentMoviesAtOnce");
        }
    }
}
