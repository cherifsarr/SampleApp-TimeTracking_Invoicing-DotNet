namespace TimeTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RealmIdChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OAuthTokens", "realmid", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OAuthTokens", "realmid", c => c.Int(nullable: false));
        }
    }
}
