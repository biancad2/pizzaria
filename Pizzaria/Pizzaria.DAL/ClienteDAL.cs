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
    public static class ClienteDAL
    {
        public static int inserirClienteDAL(Cliente objCliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_CLIENTES (NM_CLIENTE, NR_TELEFONE, DS_ENDERECO, DS_BAIRRO) VALUES (@Nome, @Telefone, @Endereco, @Bairro)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objCliente.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objCliente.Telefone;
            Comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = objCliente.Endereco;
            Comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = objCliente.Bairro;
            Conexao.Open();
            Comando.ExecuteNonQuery();
            Comando.CommandText = "SELECT MAX(ID_CLIENTE) FROM TB_CLIENTES";
            return int.Parse(Comando.ExecuteScalar().ToString());
                }

        public static List<Cliente> BuscarClienteDAL(string[] filtrospesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString= Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CLIENTE, NM_CLIENTE, NR_TELEFONE, DS_ENDERECO, DS_BAIRRO FROM TB_CLIENTES WHERE 1=1";
            if (filtrospesquisa[0]!=String.Empty)
            {
                Comando.CommandText += "AND NM_CLIENTE LIKE '%' + @Nome + '%'";
                Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = filtrospesquisa[0];
            }

            if (filtrospesquisa[1] != String.Empty)
            {
                Comando.CommandText += "AND NR_TELEFONE LIKE '%' + @Telefone + '%'";
                Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = filtrospesquisa[1];
            }
            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();
            List<Cliente> Clientes = new List<Cliente>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Cliente objCliente = new Cliente();
                    objCliente.Id = Convert.ToInt32(Dr["ID_CLIENTE"]);
                    objCliente.Nome = Convert.ToString(Dr["NM_CLIENTE"]);
                    objCliente.Telefone = Convert.ToString(Dr["NR_TELEFONE"]);
                    objCliente.Endereco = Convert.ToString(Dr["DS_ENDERECO"]);
                    objCliente.Bairro = Convert.ToString(Dr["DS_BAIRRO"]);
                    Clientes.Add(objCliente);
                }
            }
            return Clientes;
        }
        public static Cliente BuscarClienteDAL(int CodigoCliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString= Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CLIENTE, NM_CLIENTE, NR_TELEFONE, DS_ENDERECO, DS_BAIRRO FROM TB_CLIENTES WHERE ID_CLIENTE = @IdCliente";
            Comando.Parameters.Add("IdCliente", SqlDbType.Int).Value = CodigoCliente;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Cliente objCliente = new Cliente();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    objCliente.Id = Convert.ToInt32(Dr["ID_CLIENTE"]);
                    objCliente.Nome = Convert.ToString(Dr["NM_CLIENTE"]);
                    objCliente.Telefone = Convert.ToString(Dr["NR_TELEFONE"]);
                    objCliente.Endereco = Convert.ToString(Dr["DS_ENDERECO"]);
                    objCliente.Bairro = Convert.ToString(Dr["DS_BAIRRO"]);
                }
            }

            return objCliente;
        }

        public static void AtualizarClienteDAL(Cliente objCliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE TB_CLIENTES SET NM_CLIENTE = @Nome, NR_TELEFONE = @Telefone,  DS_ENDERECO = @ENDERECO, DS_BAIRRO = @BAIRRO WHERE ID_CLIENTE = @IdCliente";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objCliente.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objCliente.Telefone;
            Comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = objCliente.Endereco;
            Comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = objCliente.Bairro;
            Comando.Parameters.Add("IdCliente", SqlDbType.Int).Value = objCliente.Id;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static void ExcluirCliente(int IdCliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE TB_CLIENTES WHERE ID_CLIENTE = @IdCliente";
            Comando.Parameters.Add("IdCliente", SqlDbType.Int).Value = IdCliente;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
    }
}
