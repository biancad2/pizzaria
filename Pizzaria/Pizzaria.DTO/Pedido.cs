using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class Pedido
    {
        private int id;
        private int idCliente;
        private int idStatus;
        private string formapgt;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public int IdCliente
        {
            get
            {
                return idCliente;
            }
            set
            {
                idCliente = value;
            }
        }
        public int IdStatus
        {
            get
            {
                return idStatus;
            }
            set
            {
                idStatus = value;
            }
        }
        public string Formapgt
        {
            get
            {
                return formapgt;
            }
            set
            {
                formapgt = value;
            }
        }

    }
}
