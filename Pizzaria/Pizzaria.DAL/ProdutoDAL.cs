using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Pizzaria.DTO;

namespace Pizzaria.DAL
{
    public class ProdutoDAL
    {
        public static int InserirProdutoDAL(Produto objProduto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_PRODUTOS (NM_PRODUTO, VL_PRODUTO, DS_PRODUTO, ID_CATEGORIA) VALUES (@Nome, @Valor, @Descricao, @IdCat)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objProduto.Nome;
            Comando.Parameters.Add("Valor", SqlDbType.Float).Value = objProduto.Valor;
            Comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = objProduto.Descricao;
            Comando.Parameters.Add("IdCat", SqlDbType.Int).Value = objProduto.IdCat;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(ID_PRODUTO) FROM TB_PRODUTOS";
           
            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        public static List<Produto> BuscarProdutoDAL(string[] filtrosPesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_PRODUTO, NM_PRODUTO, VL_PRODUTO, DS_PRODUTO, ID_CATEGORIA FROM TB_PRODUTOS WHERE 1 = 1";

            if (filtrosPesquisa[0] != String.Empty)
            {
                Comando.CommandText += " AND ID_PRODUTO LIKE '%' + @IdProduto + '%' ";
                Comando.Parameters.Add("IdProduto", SqlDbType.Int).Value = filtrosPesquisa[0];
            }

            if (filtrosPesquisa[1] != String.Empty)
            {
                Comando.CommandText += " AND NM_PRODUTO LIKE '%' + @Nome + '%' ";
                Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = filtrosPesquisa[1];
            }

            /*if (filtrosPesquisa[2] != String.Empty)
            {
                Comando.CommandText += " AND ID_CATEGORIA LIKE '%' + @IdCat + '%' ";
                Comando.Parameters.Add("IdCat", SqlDbType.Int).Value = filtrosPesquisa[2];
            }*/
            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            List<Produto> Produtos = new List<Produto>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Produto objProduto = new Produto();
                    objProduto.Id = Convert.ToInt32(Dr["ID_PRODUTO"]);
                    objProduto.Nome = Convert.ToString(Dr["NM_PRODUTO"]);
                    objProduto.Valor = Convert.ToInt32(Dr["VL_PRODUTO"]);
                    objProduto.Descricao = Convert.ToString(Dr["DS_PRODUTO"]);
                    objProduto.IdCat = Convert.ToInt32(Dr["ID_CATEGORIA"]);
                    Produtos.Add(objProduto);
                }
            }

            return Produtos;
        }

        public static Produto BuscarProdutoDAL(int CodigoProduto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_PRODUTO, NM_PRODUTO, VL_PRODUTO, DS_PRODUTO, ID_CATEGORIA FROM TB_PRODUTOS WHERE ID_PRODUTO = @IdProduto";
            Comando.Parameters.Add("IdProduto", SqlDbType.Int).Value = CodigoProduto;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Produto objProduto = new Produto();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    objProduto.Id = Convert.ToInt32(Dr["ID_PRODUTO"]);
                    objProduto.Nome = Convert.ToString(Dr["NM_PRODUTO"]);
                    objProduto.Valor = Convert.ToInt32(Dr["VL_PRODUTO"]);
                    objProduto.Descricao = Convert.ToString(Dr["DS_PRODUTO"]);
                    objProduto.IdCat = Convert.ToInt32(Dr["ID_CATEGORIA"]);
                }
            }

            return objProduto;
        }

        public static void AtualizarProdutoDAL(Produto objProduto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE TB_PRODUTOS SET NM_PRODUTO = @Nome, VL_PRODUTO = @Valor,  DS_PRODUTO = @Descricao WHERE ID_PRODUTO = @IdProduto";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objProduto.Nome;
            Comando.Parameters.Add("Valor", SqlDbType.Float).Value = objProduto.Valor;
            Comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = objProduto.Descricao;
            Comando.Parameters.Add("IdCat", SqlDbType.Int).Value = objProduto.IdCat;
            Comando.Parameters.Add("IdProduto", SqlDbType.Int).Value = objProduto.Id;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static Produto ProdutoCategoriaDAL(int CodigoCat)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT TB_PRODUTOS.NM_PRODUTO, TB_CATEGORIA.NM_CATEGORIA FROM TB_PRODUTOS INNER JOIN TB_CATEGORIA ON TB_PRODUTOS.ID_CATEGORIA = TB_CATEGORIA.ID_CATEGORIA";
            Comando.Parameters.Add("IdCategoria", SqlDbType.Int).Value = CodigoCat;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Produto objProduto = new Produto();
            Categoria objCategoria = new Categoria();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    
                    objProduto.Nome = Convert.ToString(Dr["NM_PRODUTO"]);
                    objCategoria.Nome= Convert.ToString(Dr["NM_PRODUTO"]);
                }
            }

            return objProduto;
        }


        public static void ExcluirProduto(int IdProduto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE TB_PRODUTOS WHERE ID_PRODUTO = @IdProduto";
            Comando.Parameters.Add("IdProduto", SqlDbType.Int).Value = IdProduto;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
       
    }
}
