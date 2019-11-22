using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class Produto
    {
        private int id;
        private string nome;
        private float valor;
        private string descricao;
        private int idCat;

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

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public float Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                descricao = value;
            }
        }

        public int IdCat
        {
            get
            {
                return idCat;
            }
            set
            {
                idCat = value;
            }
        }

        
    }
}
