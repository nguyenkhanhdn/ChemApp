namespace ChemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ten : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Formula = c.String(),
                        ImageUrl = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chems");
        }
    }
}
