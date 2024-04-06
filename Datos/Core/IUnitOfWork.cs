using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;
        int Guardar();
        void ComenzarTransaccion();
        void ReversarTransaccion();
        void ConfirmarTransaccion();
    }
}
