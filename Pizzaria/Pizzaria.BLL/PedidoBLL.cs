using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DAL;
using Pizzaria.DTO;

namespace Pizzaria.BLL
{
    public class PedidoBLL
    {
        public static int InserirPedidoBLL(Pedido objPedido)
        {
            return PedidoDAL.InserirPedidoDAL(objPedido);
        }
        public static List<Cliente> BuscarClienteBLL(string[] filtrosPesquisa)
        {
            return PedidoDAL.BuscarClienteDAL(filtrosPesquisa);
        }
        public static List<Cliente> PassarClienteBLL()
        {
           
            return PedidoDAL.PassarCliente();
        }
       public static List<Pedido> BuscarClienteStatusBLL()
        {
            return PedidoDAL.BuscarClienteStatusDAL();
        }


    }
}
