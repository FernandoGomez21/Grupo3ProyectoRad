namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiosTablaProductos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductosModels", "ProductoDetalle", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductosModels", "ProductoDetalle", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
