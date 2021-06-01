namespace Proyecto04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DBclientesYULies",
                c => new
                    {
                        IdDocumento = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdDocumento);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DBclientesYULies");
        }
    }
}
