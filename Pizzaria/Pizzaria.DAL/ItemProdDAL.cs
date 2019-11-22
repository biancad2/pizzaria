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
    public class ItemProdDAL
    {
        public static int InserirItemPedDAL(ItemProd objProd)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_ITEM_PEDIDOS (ID_PEDIDO, ID_PRODUTO, QT_PRODUTO) VALUES (@IdPedido, @IdProduto, @Quantidade)";

            Comando.Parameters.Add("IdPedido", SqlDbType.Int).Value = objProd.IdPedido;
            Comando.Parameters.Add("IdProduto", SqlDbType.Int).Value = objProd.IdProduto;
            Comando.Parameters.Add("Quantidade", SqlDbType.Float).Value = objProd.QtProduto;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(ID_ITEM_PEDIDO) FROM TB_ITEM_PEDIDOS";

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

        public static void ExcluirItemDAL(int IdItem)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE TB_ITEM_PEDIDOS WHERE ID_ITEM_PEDIDO = @IdItemPed";
            Comando.Parameters.Add("IdItemPed", SqlDbType.Int).Value = IdItem;
            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
    }
}
