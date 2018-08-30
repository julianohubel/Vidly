namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {

            Sql("Insert into MemberShipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) values (1,0,0,0)");
            Sql("Insert into MemberShipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) values (2,30,1,10)");
            Sql("Insert into MemberShipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) values (2,90,3,15)");
            Sql("Insert into MemberShipTypes (Id, SingUpFee, DurationInMonths, DiscountRate) values (2,300,12,30)");
        }
        
        public override void Down()
        {
        }
    }
}
