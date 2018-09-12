namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMembershipTypeSingUp : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.MembershipTypes", "SingUpFee", c => c.Short(nullable: false));
            //DropColumn("dbo.MembershipTypes", "SingÚpFee");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.MembershipTypes", "SingÚpFee", c => c.Short(nullable: false));
            //DropColumn("dbo.MembershipTypes", "SingUpFee");
        }
    }
}
