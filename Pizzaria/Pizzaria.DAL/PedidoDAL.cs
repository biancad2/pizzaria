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
    public class PedidoDAL
    {
        public static int InserirPedidoDAL(Pedido objPedido)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;
            
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_PEDIDOS (ID_CLIENTE, ID_STATUS, DS_FORMAPAG) VALUES (@IdCli, @IdStatus, @Descricao)";
         
            Comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = objPedido.Formapgt;
            Comando.Parameters.Add("IdCli", SqlDbType.Int).Value = objPedido.IdCliente;
            Comando.Parameters.Add("IdStatus", SqlDbType.Int).Value = objPedido.IdStatus;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(ID_PEDIDO) FROM TB_PEDIDOS";

            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        public static List<Cliente> BuscarClienteDAL(string[] filtrospesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CLIENTE, NM_CLIENTE, NR_TELEFONE, DS_ENDERECO, DS_BAIRRO FROM TB_CLIENTES WHERE 1=1";
            if (filtrospesquisa[0] != String.Empty)
            {
                Comando.CommandText += "AND NM_CLIENTE LIKE '%' + @Nome + '%' OR NR_TELEFONE LIKE '%' + @Telefone + '%'";
                Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = filtrospesquisa[0];
                Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = filtrospesquisa[0];
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

        public static List<Cliente> PassarCliente()
        {
            List<Cliente> Clientes = new List<Cliente>();
            return Clientes;
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
                    objCategoria.Nome = Convert.ToString(Dr["NM_PRODUTO"]);
                }
            }

            return objProduto;
        }

        public static List<Pedido> BuscarClienteStatusDAL()
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            List<Pedido> Pedidos = new List<Pedido>();
           
            /*Comando.CommandText = "SELECT TB_PEDIDOS.ID_PEDIDO TB_CLIENTES.NM_CLIENTE, TB_CATEGORIA.NM_CATEGORIA FROM TB_PRODUTOS INNER JOIN TB_CATEGORIA ON TB_PRODUTOS.ID_CATEGORIA = TB_CATEGORIA.ID_CATEGORIA";*/
            Comando.CommandText = "SELECT TB_PEDIDOS.ID_PEDIDO, TB_CLIENTES.ID_CLIENTE, TB_CLIENTES.NM_CLIENTE, TB_STATUS.ID_STATUS, TB_STATUS.NM_STATUS, TB_PEDIDOS.DS_FORMAPAG FROM TB_PEDIDOS INNER JOIN TB_CLIENTES ON TB_PEDIDOS.ID_CLIENTE = TB_CLIENTES.ID_CLIENTE INNER JOIN TB_STATUS ON TB_PEDIDOS.ID_STATUS = TB_STATUS.ID_STATUS";
           
            

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Pedido objPedido = new Pedido();
                    objPedido.Id = Convert.ToInt32(Dr["ID_PEDIDO"]);
                    objPedido.Formapgt = Convert.ToString(Dr["DS_FORMAPAG"]);
                    objPedido.IdCliente= Convert.ToInt32(Dr["ID_CLIENTE"]);
                    objPedido.IdStatus = Convert.ToInt32(Dr["ID_STATUS"]);

                }
            }

            return Pedidos;
        }

    }
}
