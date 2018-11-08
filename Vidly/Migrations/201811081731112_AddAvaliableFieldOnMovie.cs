namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvaliableFieldOnMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Avaliable", c => c.Int(nullable: false));
            Sql("update movies set Avaliable = Stock");

        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Avaliable");
        }
    }
}
