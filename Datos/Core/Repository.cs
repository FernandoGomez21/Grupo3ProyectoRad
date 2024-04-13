using System.Collections.Generic;
using System.Linq;
using Datos.BaseDatos;

namespace Datos.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public ProyectoContext dbcontext;

        public Repository()
        {
        }
        public void Agregar(T entidad)
        {
            dbcontext.Set<T>().Add(entidad);
        }

        public void AgregarRango(IEnumerable<T> entidades)
        {
            dbcontext.Set<T>().AddRange(entidades);
            dbcontext.SaveChanges();
        }

        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }

        public void Editar(T entidad)
        {
            dbcontext.Set<T>();
        }

        public void Eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
        }
    }
}
