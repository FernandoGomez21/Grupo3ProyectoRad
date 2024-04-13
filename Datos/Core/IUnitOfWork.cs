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
