namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioenTablaClientesModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClienteModels", "CategoriaId", "dbo.CategoriaModels");
            DropIndex("dbo.ClienteModels", new[] { "CategoriaId" });
            AddColumn("dbo.ClienteModels", "CondicionPagoId", c => c.Int(nullable: false));
            CreateIndex("dbo.ClienteModels", "CondicionPagoId");
            AddForeignKey("dbo.ClienteModels", "CondicionPagoId", "dbo.CondicionPago", "CondicionPagoId");
            DropColumn("dbo.ClienteModels", "CategoriaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClienteModels", "CategoriaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ClienteModels", "CondicionPagoId", "dbo.CondicionPago");
            DropIndex("dbo.ClienteModels", new[] { "CondicionPagoId" });
            DropColumn("dbo.ClienteModels", "CondicionPagoId");
            CreateIndex("dbo.ClienteModels", "CategoriaId");
            AddForeignKey("dbo.ClienteModels", "CategoriaId", "dbo.CategoriaModels", "CategoriaId");
        }
    }
}
