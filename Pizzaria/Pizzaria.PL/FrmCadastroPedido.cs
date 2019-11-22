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
    public partial class FrmCadastroPedido : Form
    {
        public Cliente objCliente;
        public Status objStatus;
        public Pedido objPedido;
        public ItemProd objItem;

        public FrmCadastroPedido()
        {
            InitializeComponent();
            objPedido = new Pedido();
            objCliente = new Cliente();
            objStatus = new Status();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do item selecionado?", "Excluir Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CodigoItemLinhaSelecionada = int.Parse(dgvProdutos.CurrentRow.Cells["Column6_IdItem"].Value.ToString());

                ItemProdBLL.ExcluirItemBLL(CodigoItemLinhaSelecionada);
                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
            }
        }

        private void btn_PesquisarCli_Click(object sender, EventArgs e)
        {
            string[] filtrosPesquisa = { txtPesquisar.Text };

            List<Cliente> Clientes = PedidoBLL.BuscarClienteBLL(filtrosPesquisa);
            if (Clientes.Count == 0)
            {
                FrmCadastroCliente FrmCadastro = new FrmCadastroCliente(0);
                FrmCadastro.ShowDialog();
            }
            else
            {
                if (Clientes.Count == 1) {
                    foreach (var objCliente in Clientes)
                    {
                        lblNomeCli.Text = objCliente.Nome;
                        lblTelCli.Text = objCliente.Telefone;
                        lblEndCli.Text = objCliente.Endereco;
                        lblBairro.Text = objCliente.Bairro;
                    }
                }
                else
                { 
                    FrmPesquisaCliente FrmPesquisaCli = new FrmPesquisaCliente(1);
                    FrmPesquisaCli.ShowDialog();
                }

              
            }
            foreach (var objCliente in Clientes)
            {
                txtId.Text=objCliente.Id.ToString();
                lblNomeCli.Text = objCliente.Nome;
                lblTelCli.Text = objCliente.Telefone;
                lblEndCli.Text = objCliente.Endereco;
                lblBairro.Text = objCliente.Bairro;
            }
        }

        private void btn_AdcCli_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente FrmCadastro = new FrmCadastroCliente(0);
            FrmCadastro.ShowDialog();
        }

        private void btn_ApagarCli_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            lblNomeCli.Text = "";
            lblTelCli.Text = "";
            lblEndCli.Text = "";
            lblBairro.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();

        }

        private void btn_IncluirProd_Click(object sender, EventArgs e)
        {

            FrmAdcItem FrmADC = new FrmAdcItem(lblIdPed.Text);
            var result = FrmADC.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] linhaProduto = { FrmADC.objCategoria.Nome, FrmADC.objProduto.Id.ToString(), FrmADC.objProduto.Nome, FrmADC.objProduto.Descricao, FrmADC.objItem.QtProduto.ToString(), FrmADC.objProduto.Valor.ToString(), FrmADC.objItem.Id.ToString()
                };
                dgvProdutos.Rows.Add(linhaProduto);
            }
         
            
        }

   

        private void btn_Teste_Click(object sender, EventArgs e)
        {
            objPedido.IdCliente = int.Parse(txtId.Text);
            objCliente.Nome = lblNomeCli.Text;
            objStatus.Id = 2;
            objPedido.IdStatus = objStatus.Id;
            objPedido.Formapgt = rdbDinheiro.Checked ? "DINHEIRO" : "CARTAO";
            objPedido.Id = PedidoBLL.InserirPedidoBLL(objPedido);
            lblIdPed.Text = objPedido.Id.ToString();

        }
    }
}
