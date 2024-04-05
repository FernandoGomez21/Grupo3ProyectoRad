namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaPedidoDetalle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PedidoDetalle",
                c => new
                    {
                        PedidoDetalleId = c.Int(nullable: false, identity: true),
                        PedidoId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        ProductosId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoDetalleId)
                .ForeignKey("dbo.Pedido", t => t.PedidoId)
                .ForeignKey("dbo.ProductosModels", t => t.ProductosId)
                .Index(t => t.PedidoId)
                .Index(t => t.ProductosId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PedidoDetalle", "ProductosId", "dbo.ProductosModels");
            DropForeignKey("dbo.PedidoDetalle", "PedidoId", "dbo.Pedido");
            DropIndex("dbo.PedidoDetalle", new[] { "ProductosId" });
            DropIndex("dbo.PedidoDetalle", new[] { "PedidoId" });
            DropTable("dbo.PedidoDetalle");
        }
    }
}
