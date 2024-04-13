using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Datos.BaseDatos.Models;

namespace Datos.BaseDatos
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext() : base("name=ProyectoRad")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Utilizamos using System.Data.Entity.ModelConfiguration.Conventions;
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //No queremos Nombres en plural
        }
        public DbSet<CategoriaModels> Categorias { get; set; }/**/
        public DbSet<GrupoDescuento> GrupoDescuentos { get; set; }
        public DbSet<ClienteModels> Cliente { get; set; } /**/
        public DbSet<UnidadMedida> unidadMedidas { get; set; }
        public DbSet<CondicionPago> condicionPagos { get; set; }
        public DbSet<ProductosModels> Productos { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<PedidoDetalle> pedidosDetalle { get; set; }
        public DbSet<FacturaDetalle> facturaDetalle { get; set; }


    }
}
