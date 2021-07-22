namespace SistemaWebVuelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vueloes",
                c => new
                    {
                        VueloID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Destino = c.String(nullable: false, maxLength: 50, unicode: false),
                        Origen = c.String(nullable: false, maxLength: 50, unicode: false),
                        Matricula = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.VueloID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vueloes");
        }
    }
}
