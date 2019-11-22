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
    public class StatusDAL
    {
        public static Status BuscarStatusDAL(int CodigoStatus)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT NM_STATUS FROM TB_STATUS WHERE ID_STATUS = @IdStatus";
            Comando.Parameters.Add("IdStatus", SqlDbType.Int).Value = CodigoStatus;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Status objStatus = new Status();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                   
                    objStatus.Nome = Convert.ToString(Dr["NM_STATUS"]);
                    
                }
            }

            return objStatus;
        }
        public static List<Status> BuscarStatusDAL(string[] filtrosPesquisa)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Pizzaria.DAL.Properties.Settings.Default.Configuração;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT NM_STATUS WHERE 1 = 1";

            if (filtrosPesquisa[0] != String.Empty)
            {
                Comando.CommandText += " AND ID_STATUS LIKE '%' + @IdStatus + '%' ";
                Comando.Parameters.Add("IdStatus", SqlDbType.Int).Value = filtrosPesquisa[0];
            }

            

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            List<Status> Status00 = new List<Status>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Status objStatus = new Status();
                    objStatus.Id = Convert.ToInt32(Dr["ID_STATUS"]);
                    objStatus.Nome = Convert.ToString(Dr["NM_STATUS"]);
                    Status00.Add(objStatus);
                }
            }

            return Status00;
        }
    }
}
