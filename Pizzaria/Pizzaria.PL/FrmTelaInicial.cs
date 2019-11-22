using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.PL
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void btn_AdcCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente FrmCadastro = new FrmCadastroCliente();
            FrmCadastro.ShowDialog();
        }

        private void btn_PesqCli_Click(object sender, EventArgs e)
        {
            FrmPesquisaCliente FrmPesquisa = new FrmPesquisaCliente();
            FrmPesquisa.ShowDialog();
        }

        private void btn_AdcPedido_Click(object sender, EventArgs e)
        {
            FrmCadastroPedido FrmCadastro = new FrmCadastroPedido();
            FrmCadastro.ShowDialog();
        }

        private void btn_PesquisarPed_Click(object sender, EventArgs e)
        {
            FrmPedidos FrmPedido = new FrmPedidos();
            FrmPedido.ShowDialog();
        }

        private void btn_AdcProd_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto FrmCadastro = new FrmCadastroProduto();
            FrmCadastro.ShowDialog();
        }

        private void btn_PesqProd_Click(object sender, EventArgs e)
        {
            FrmPesquisaProduto FrmPesquisa = new FrmPesquisaProduto();
            FrmPesquisa.ShowDialog();
        }
    }
}
