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
    public class CategoriaDAL
    {
        public static int InserirCategoriaDAL(Categoria objCategoria)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString= Pizzaria.DAL.Properties.Settings.Default.Configuração;
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_CATEGORIA (NM_CATEGORIA, DS_CATEGORIA) VALUES (@Nome, @Descricao) ";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objCategoria.Nome;
            Comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = objCategoria.Descricao;
            Conexao.Open();
            Comando.ExecuteNonQuery();
            Comando.CommandText = "SELECT MAX(ID_CATEGORIA) FROM TB_CATEGORIA";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }


        public static void AtualizarCategoriaDAL(Categoria objCategoria)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE TB_CATEGORIA SET NM_CATEGORIA = @Nome, DS_CATEGORIA = @Descricao WHERE ID_CATEGORIA = @IdCategoria";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objCategoria.Nome;
            Comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = objCategoria.Descricao;
            Comando.Parameters.Add("IdCategoria", SqlDbType.Int).Value = objCategoria.Id;
            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static void ExcluirCategoria(int IdCategoria)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE TB_CATEGORIA WHERE ID_CATEGORIA = @IdCategoria";
            Comando.Parameters.Add("IdCategoria", SqlDbType.Int).Value = IdCategoria;
            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
        public static List<Categoria> BuscarCategoriaDAL()
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CATEGORIA, NM_CATEGORIA, DS_CATEGORIA FROM TB_CATEGORIA WHERE 1 = 1";

         
            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            List<Categoria> Categorias = new List<Categoria>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Categoria objCategoria = new Categoria();
                    objCategoria.Id = Convert.ToInt32(Dr["ID_CATEGORIA"]);
                    objCategoria.Nome = Convert.ToString(Dr["NM_CATEGORIA"]);
                    objCategoria.Descricao = Convert.ToString(Dr["DS_CATEGORIA"]);
                    Categorias.Add(objCategoria);
                }
            }

            return Categorias;
        }
        public static Categoria BuscarCategoriaDAL(int CodigoCategoria)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CATEGORIA, NM_CATEGORIA,  DS_CATEGORIA FROM TB_CATEGORIA WHERE ID_CATEGORIA = @IdCategoria";
            Comando.Parameters.Add("IdCategoria", SqlDbType.Int).Value = CodigoCategoria;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Categoria objCategoria = new Categoria();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    objCategoria.Id = Convert.ToInt32(Dr["ID_CATEGORIA"]);
                    objCategoria.Nome = Convert.ToString(Dr["NM_CATEGORIA"]);
                    objCategoria.Descricao = Convert.ToString(Dr["DS_CATEGORIA"]);
                }
            }

            return objCategoria;
        }
        public static List<Categoria> BuscarCategoriaDAL(string[] filtrosPesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CATEGORIA, NM_CATEGORIA,  DS_CATEGORIA FROM TB_CATEGORIA WHERE 1 = 1";

            if (filtrosPesquisa[0] != String.Empty)
            {
                Comando.CommandText += " AND NM_CATEGORIA LIKE '%' + @IdCategoria + '%' ";
                Comando.Parameters.Add("IdCategoria", SqlDbType.Int).Value = filtrosPesquisa[0];
            }

           

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            List<Categoria> Categorias = new List<Categoria>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Categoria objCategoria = new Categoria();
                    objCategoria.Id = Convert.ToInt32(Dr["ID_CATEGORIA"]);
                    objCategoria.Nome = Convert.ToString(Dr["NM_CATEGORIA"]);
                    objCategoria.Descricao = Convert.ToString(Dr["DS_CATEGORIA"]);
                    Categorias.Add(objCategoria);
                }
            }

            return Categorias;
        }

    }
}
