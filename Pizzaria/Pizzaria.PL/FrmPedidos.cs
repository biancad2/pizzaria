using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.DTO;
using Pizzaria.BLL;

namespace Pizzaria.PL
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
            /*FrmCadastroPedido FormCadastro = new FrmCadastroPedido();*/

            /*string[] linhaPedido = { FormCadastro.objPedido.Id.ToString(), FormCadastro.objCliente.Nome, FormCadastro.objStatus.Nome, FormCadastro.objStatus.Nome };
            dgvPedidos.Rows.Add(linhaPedido);*/
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
                 FrmCadastroPedido FormCadastro = new FrmCadastroPedido();
            var result = FormCadastro.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] linhaPedido = { FormCadastro.objPedido.Id.ToString(), FormCadastro.objPedido.IdCliente.ToString(), FormCadastro.objCliente.Nome, FormCadastro.objPedido.Formapgt };
                dgvPedidos.Rows.Add(linhaPedido);
            }
            
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            FrmCadastroPedido FormCadastro = new FrmCadastroPedido();
            List<Pedido> Pedidos = PedidoBLL.BuscarClienteStatusBLL();
            foreach (var objPedido in Pedidos)
            {
                string[] linhaCategoria = { objPedido.Id.ToString(), FormCadastro.objCliente.Id.ToString(), FormCadastro.objCliente.Nome, FormCadastro.objStatus.Nome, objPedido.Formapgt };
                dgvPedidos.Rows.Add(linhaCategoria);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCadastroPedido FormCadastro = new FrmCadastroPedido();
            List<Pedido> Pedidos = PedidoBLL.BuscarClienteStatusBLL();
            foreach (var objPedido in Pedidos)
            {
                string[] linhaCategoria = { objPedido.Id.ToString(), FormCadastro.objCliente.Id.ToString(), FormCadastro.objCliente.Nome, FormCadastro.objStatus.Nome, objPedido.Formapgt };
                dgvPedidos.Rows.Add(linhaCategoria);
            }
        }
    }
}
