using System.Collections.Generic;
using System.Linq;
using Datos;
using Datos.BaseDatos.Models;
using Negocio.Comun;

namespace Negocio
{
    public class NClienteModels
    {
        private DClienteModels dclientes;


        public NClienteModels()
        {
            dclientes = new DClienteModels();
        }

        public List<ClienteModels> TodoslosClientes()
        {
            return dclientes.ClientesTodos();
        }

        public List<ClienteModels> ClientesActivos()
        {
            return dclientes.ClientesTodos().Where(c => c.Estado == true).ToList();
        }
        public List<CargarCombos> CargaCombo()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var clientes = dclientes.ClientesTodos()
                                      .Where(c => c.Estado == true).Select(c => new
                                      {
                                          c.ClienteId,
                                          c.ClienteCombo,
                                      })
                                      .ToList();
            foreach (var item in clientes)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.ClienteId,
                    Nombre = item.ClienteCombo
                });
            }

            return Datos;
        }
        public int AgregarClientes(ClienteModels clientes)
        {
            return dclientes.GuardarClientes(clientes);
        }

        public int EditarClientes(ClienteModels clientes)
        {
            return dclientes.GuardarClientes(clientes);
        }

        public int EliminarCliente(int clientes)
        {
            return dclientes.EliminarCliente(clientes);
        }


    }
}
