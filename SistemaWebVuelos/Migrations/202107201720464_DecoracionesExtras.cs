namespace SistemaWebVuelos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DecoracionesExtras : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Vueloes", newName: "Vuelo");
            AlterColumn("dbo.Vuelo", "Matricula", c => c.String(nullable: false, maxLength: 5, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vuelo", "Matricula", c => c.String(nullable: false));
            RenameTable(name: "dbo.Vuelo", newName: "Vueloes");
        }
    }
}
