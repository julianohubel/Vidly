namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres values ( 'Comedy')");
            Sql("Insert into Genres values  ( 'Action')");
            Sql("Insert into Genres values  ( 'Scary')");
            Sql("Insert into Genres values  ( 'Family')");
            Sql("Insert into Genres values  ( 'Romance')");

        }
        
        public override void Down()
        {
        }
    }
}
