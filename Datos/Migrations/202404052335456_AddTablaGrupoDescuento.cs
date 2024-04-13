namespace Datos.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddTablaGrupoDescuento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoDescuento",
                c => new
                {
                    GrupoDescuentoId = c.Int(nullable: false, identity: true),
                    Codigo = c.String(nullable: false, maxLength: 50),
                    DescripcionGD = c.String(nullable: false, maxLength: 50),
                    Estado = c.Boolean(nullable: false),
                    Porcentaje = c.Int(nullable: false),
                    FechaCreacion = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.GrupoDescuentoId);

        }

        public override void Down()
        {
            DropTable("dbo.GrupoDescuento");
        }
    }
}
