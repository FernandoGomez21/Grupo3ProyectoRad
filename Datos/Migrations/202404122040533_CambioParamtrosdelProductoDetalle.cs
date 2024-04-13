namespace Datos.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CambioParamtrosdelProductoDetalle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductosModels", "ProductoDetalle", c => c.String(nullable: false, maxLength: 50));
        }

        public override void Down()
        {
            AlterColumn("dbo.ProductosModels", "ProductoDetalle", c => c.String(nullable: false));
        }
    }
}
