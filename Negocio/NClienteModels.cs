using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos.Models;

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
