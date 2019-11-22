using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DAL;
using Pizzaria.DTO;

namespace Pizzaria.BLL
{
    public class ItemProdBLL
    {
        public static int InserirItemPedBLL(ItemProd objProd)
        {
            return ItemProdDAL.InserirItemPedDAL(objProd);
        }
        public static void ExcluirItemBLL(int IdItem)
        {
            ItemProdDAL.ExcluirItemDAL(IdItem);
        }
    }
}
