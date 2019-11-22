using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DAL;
using Pizzaria.DTO;
namespace Pizzaria.BLL
{
    public class StatusBLL
    {
        public static Status BuscarStatusBLL(int CodigoStatus)
        {
            return StatusDAL.BuscarStatusDAL(CodigoStatus);
        }
        public static List<Status> BuscarStatusBLL(string[] filtrosPesquisa)
        {
            return StatusDAL.BuscarStatusDAL(filtrosPesquisa);
        }
    }
}
