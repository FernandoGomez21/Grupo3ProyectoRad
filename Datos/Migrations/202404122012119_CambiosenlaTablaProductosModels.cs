namespace Datos.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CambiosenlaTablaProductosModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductosModels", "ProductoDetalle", c => c.String(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.ProductosModels", "ProductoDetalle");
        }
    }
}
