namespace Brighteye.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SortedNumbers",
                c => new
                    {
                        ValueId = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ValueId);
            
            CreateTable(
                "dbo.UnsortedNumbers",
                c => new
                    {
                        ValueId = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ValueId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnsortedNumbers");
            DropTable("dbo.SortedNumbers");
        }
    }
}
