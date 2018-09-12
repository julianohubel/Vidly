namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres values (1, 'Comedy')");
            Sql("Insert into Genres values  (2, 'Action')");
            Sql("Insert into Genres values  (3, 'Scary')");
            Sql("Insert into Genres values  (4, 'Family')");
            Sql("Insert into Genres values  (5, 'Romance')");

        }
        
        public override void Down()
        {
        }
    }
}
