using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.DTO;
using Pizzaria.DAL;

namespace Pizzaria.BLL
{
    public class CategoriaBLL
    {
        public static int InserirCategoriaBLL(Categoria objCategoria)
        {
            return CategoriaDAL.InserirCategoriaDAL(objCategoria);
        }
        public static List<Categoria> BuscarCategoriaBLL()
        {
            return CategoriaDAL.BuscarCategoriaDAL();
        }
        public static Categoria BuscarCategoriaBLL(int CodigoCategoria)
        {
            return CategoriaDAL.BuscarCategoriaDAL(CodigoCategoria);
        }
        public static List<Categoria> BuscarCategoriaBLL(string[] filtrosPesquisa)
        {
            return CategoriaDAL.BuscarCategoriaDAL(filtrosPesquisa);
        }
        public static void AtualizarCategoriaBLL(Categoria objCategoria)
        {
            CategoriaDAL.AtualizarCategoriaDAL(objCategoria);
        }

        public static void ExcluirCategoriaBLL(int CodigoCategoria)
        {
            CategoriaDAL.ExcluirCategoria(CodigoCategoria);
        }

    }
}
