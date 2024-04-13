namespace Datos.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddTablaClienteModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteModels",
                c => new
                {
                    ClienteId = c.Int(nullable: false, identity: true),
                    Codigo = c.String(nullable: false, maxLength: 15),
                    Nombres = c.String(nullable: false, maxLength: 50),
                    Apellidos = c.String(nullable: false, maxLength: 50),
                    GrupoDescuentoId = c.Int(nullable: false),
                    CategoriaId = c.Int(nullable: false),
                    Estado = c.Boolean(nullable: false),
                    FechaCreacion = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.CategoriaModels", t => t.CategoriaId)
                .ForeignKey("dbo.GrupoDescuento", t => t.GrupoDescuentoId)
                .Index(t => t.GrupoDescuentoId)
                .Index(t => t.CategoriaId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.ClienteModels", "GrupoDescuentoId", "dbo.GrupoDescuento");
            DropForeignKey("dbo.ClienteModels", "CategoriaId", "dbo.CategoriaModels");
            DropIndex("dbo.ClienteModels", new[] { "CategoriaId" });
            DropIndex("dbo.ClienteModels", new[] { "GrupoDescuentoId" });
            DropTable("dbo.ClienteModels");
        }
    }
}
