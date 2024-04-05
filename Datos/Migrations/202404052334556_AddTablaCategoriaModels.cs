namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablaCategoriaModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriaModels",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 50),
                        DescripcionCM = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechadeCreacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CategoriaModels");
        }
    }
}
