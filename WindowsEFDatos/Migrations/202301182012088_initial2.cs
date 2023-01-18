namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avion",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominación = c.String(nullable: false, maxLength: 50, unicode: false),
                        LineaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineaAerea", t => t.LineaId, cascadeDelete: true)
                .Index(t => t.LineaId);
            
            CreateTable(
                "dbo.LineaAerea",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaId", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "LineaId" });
            DropTable("dbo.LineaAerea");
            DropTable("dbo.Avion");
        }
    }
}
