using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DAL;
using Pizzaria.DTO;

namespace Pizzaria.BLL
{
    public class ClienteBLL
    {
        public static int InserirClienteBLL(Cliente objCliente) {
            return ClienteDAL.inserirClienteDAL(objCliente);
        }
        public static List<Cliente> BuscarClienteBLL(string[] filtrosPesquisa)
        {
            return ClienteDAL.BuscarClienteDAL(filtrosPesquisa);
        }

        public static Cliente BuscarClienteBLL(int CodigoCliente)
        {
            return ClienteDAL.BuscarClienteDAL(CodigoCliente);
        }

        public static void AtualizarClienteBLL(Cliente objCliente)
        {
            ClienteDAL.AtualizarClienteDAL(objCliente);
        }

        public static void ExcluirClienteBLL(int CodigoCliente)
        {
            ClienteDAL.ExcluirCliente(CodigoCliente);
        }
    }
}
