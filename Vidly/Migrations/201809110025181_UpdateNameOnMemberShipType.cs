namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameOnMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MemberShipTypes set Name='Pay as you go' where Id = 1");//pay as you go
            Sql("Update MemberShipTypes set Name='Monthly' where Id = 2");//Monthly
            Sql("Update MemberShipTypes set Name='Quarterly' where Id = 3");//quarterly
            Sql("Update MemberShipTypes set Name='Yearly' where Id = 4");//Yearly           
        }
        
        public override void Down()
        {
        }
    }
}
