namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        BoatId = c.Int(nullable: false, identity: true),
                        BoatName = c.String(),
                        HourlyRate = c.String(),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.BoatId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Boats");
        }
    }
}
