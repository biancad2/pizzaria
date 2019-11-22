using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class ItemProd
    {
        private int id;
        private int idPedido;
        private int idProduto;
        private float qtProd;

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
        public int IdPedido
        {
            get
            {
                return idPedido;
            }
            set
            {
                idPedido = value;
            }
        }
        public int IdProduto
        {
            get
            {
                return idProduto;
            }
            set
            {
                idProduto = value;
            }
        }

        public float QtProduto
        {
            get
            {
                return qtProd;
            }
            set
            {
                qtProd = value;
            }
        }
    }
}
