using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Datos.BaseDatos.Models;
using Datos.Core;

namespace Datos
{
    public class DClienteModels
    {
        UnitOfWork unitOfWork;

        public DClienteModels()
        {
            unitOfWork = new UnitOfWork();
        }
        public int ClienteId { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int GrupoDescuentoId { get; set; }
        public GrupoDescuento GrupoDescuento { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaModels CategoriaModels { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }


        public List<ClienteModels> ClientesTodos()
        {
            return unitOfWork.Repository<ClienteModels>()
                            .Consulta()
                            .Include(c => c.CondicionPago)
                            .Include(c => c.GrupoDescuento)
                            .ToList();
        }

        public int GuardarClientes(ClienteModels clientes)
        {
            if (clientes.ClienteId == 0)
            {
                unitOfWork.Repository<ClienteModels>().Agregar(clientes);
                return unitOfWork.Guardar();
            }
            else
            {
                var ClienteInDb = unitOfWork.Repository<ClienteModels>().Consulta().FirstOrDefault(c => c.ClienteId == clientes.ClienteId);
                if (ClienteInDb != null)
                {
                    ClienteInDb.Codigo = clientes.Codigo;
                    ClienteInDb.Nombres = clientes.Nombres;
                    ClienteInDb.Apellidos = clientes.Apellidos;
                    ClienteInDb.GrupoDescuentoId = clientes.GrupoDescuentoId;
                    ClienteInDb.CondicionPagoId = clientes.CondicionPagoId;
                    ClienteInDb.Estado = clientes.Estado;
                    ClienteInDb.FechaCreacion = clientes.FechaCreacion;
                    unitOfWork.Repository<ClienteModels>().Editar(clientes);
                    return unitOfWork.Guardar();
                }

                return 0;

            }
        }

        public int EliminarCliente(int clientes)
        {
            var ClienteInDb = unitOfWork.Repository<ClienteModels>().Consulta().FirstOrDefault(c => c.ClienteId == clientes);
            if (ClienteInDb != null)
            {
                {
                    unitOfWork.Repository<ClienteModels>().Eliminar(ClienteInDb);
                    return unitOfWork.Guardar();
                }



            }

            return 0;
        }

    }
}
