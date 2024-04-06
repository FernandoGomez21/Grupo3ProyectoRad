using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entidad);
        void AgregarRango(IEnumerable<T> entidades);
        void Editar(T entidad);
        void Eliminar(T entidad);
        IQueryable<T> Consulta();

    }
}
