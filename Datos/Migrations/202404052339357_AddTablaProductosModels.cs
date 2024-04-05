namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaProductosModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductosModels",
                c => new
                    {
                        ProductosId = c.Int(nullable: false, identity: true),
                        UnidadMedidaId = c.Int(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        FechaCreacion = c.DateTime(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        PrecioCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductosId)
                .ForeignKey("dbo.CategoriaModels", t => t.CategoriaId)
                .ForeignKey("dbo.UnidadMedida", t => t.UnidadMedidaId)
                .Index(t => t.UnidadMedidaId)
                .Index(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductosModels", "UnidadMedidaId", "dbo.UnidadMedida");
            DropForeignKey("dbo.ProductosModels", "CategoriaId", "dbo.CategoriaModels");
            DropIndex("dbo.ProductosModels", new[] { "CategoriaId" });
            DropIndex("dbo.ProductosModels", new[] { "UnidadMedidaId" });
            DropTable("dbo.ProductosModels");
        }
    }
}
