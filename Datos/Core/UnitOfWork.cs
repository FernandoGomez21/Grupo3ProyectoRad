using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos;

namespace Datos.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProyectoContext dbcontext;
        private DbContextTransaction _transaccion;

        public UnitOfWork()
        {
            this.dbcontext = new ProyectoContext();
        }

        public void ComenzarTransaccion()
        {
            _transaccion = dbcontext.Database.BeginTransaction();
        }

        public void ConfirmarTransaccion()
        {
            _transaccion.Commit();
            _transaccion.Dispose();
            _transaccion = null;
        }

        public int Guardar()
        {
            int guardar = 0;
            if (_transaccion == null)
            {
                try
                {
                    ComenzarTransaccion();
                    guardar = dbcontext.SaveChanges();
                    ConfirmarTransaccion();
                    return guardar;
                }
                catch (Exception ex)
                {
                    ReversarTransaccion();
                    throw ex;
                }

            }

            return dbcontext.SaveChanges();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            var repository = new Repository<T>();
            repository.dbcontext = dbcontext;
            return repository; ;

        }

        public void ReversarTransaccion()
        {
            _transaccion.Rollback();
            _transaccion.Dispose();
            _transaccion = null;
        }
    }
}
