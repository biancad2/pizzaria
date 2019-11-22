using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DAL;
using Pizzaria.DTO;

namespace Pizzaria.BLL
{
   public class ProdutoBLL
    {
        public static int InserirProdutoBLL(Produto objProduto)
        {
            return ProdutoDAL.InserirProdutoDAL(objProduto);
        }

        public static List<Produto> BuscarProdutoBLL(string[] filtrosPesquisa)
        {
            return ProdutoDAL.BuscarProdutoDAL(filtrosPesquisa);
        }

        public static Produto BuscarProdutoBLL(int CodigoProduto)
        {
            return ProdutoDAL.BuscarProdutoDAL(CodigoProduto);
        }
        public static Produto ProdutoCategoriaBLL(int CodigoCategoria)
        {
            return ProdutoDAL.ProdutoCategoriaDAL(CodigoCategoria);
        }
 
        public static void AtualizarProdutoBLL(Produto objProduto)
        {
            ProdutoDAL.AtualizarProdutoDAL(objProduto);
        }

        public static void ExcluirProdutoBLL(int CodigoProduto)
        {
            ProdutoDAL.ExcluirProduto(CodigoProduto);
        }
    }
}
