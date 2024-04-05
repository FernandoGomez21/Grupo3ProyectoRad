namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaUnidadMedida : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnidadMedida",
                c => new
                    {
                        UnidadMedidaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        DescripcionUM = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UnidadMedidaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnidadMedida");
        }
    }
}
