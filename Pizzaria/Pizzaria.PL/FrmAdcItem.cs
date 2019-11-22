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
    public partial class FrmAdcItem : Form
    {
        public Produto objProduto;
        public ItemProd objItem;
        public Categoria objCategoria;
        public float soma;
       
        FrmCadastroPedido FrmPedido = new FrmCadastroPedido();
        
        public FrmAdcItem()
        {
            InitializeComponent();
           
        }
        public FrmAdcItem(string lblIdPed)
        {
            InitializeComponent();
            lblTeste.Text = lblIdPed;
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            objItem = new ItemProd();
            objProduto = new Produto();
            objCategoria = new Categoria();
          
            int CodigoProdutoLinhaSelecionada = int.Parse(dgvProdutos.CurrentRow.Cells["Column1_IdProduto"].Value.ToString());
            string NomeProduto = dgvProdutos.CurrentRow.Cells["Column2_NmProduto"].Value.ToString();
            float ValorProduto = float.Parse(dgvProdutos.CurrentRow.Cells["Column3_VlProduto"].Value.ToString());
            string DescricaoProduto = dgvProdutos.CurrentRow.Cells["Column4_DsProduto"].Value.ToString();
            int CodigoProdutoCatLinhaSelecionada = int.Parse(dgvProdutos.CurrentRow.Cells["Column5_IdCat"].Value.ToString());
            objItem.IdProduto = CodigoProdutoLinhaSelecionada;
            objProduto.Id = CodigoProdutoLinhaSelecionada;
            objProduto.Nome = NomeProduto;
            objProduto.Valor = ValorProduto;
            objProduto.Descricao = DescricaoProduto;
            objProduto.IdCat = CodigoProdutoCatLinhaSelecionada;
            objCategoria.Id = CodigoProdutoCatLinhaSelecionada;
            CategoriaBLL.BuscarCategoriaBLL(objCategoria.Id);
            
            soma = soma + objProduto.Valor;
            objItem.IdPedido = int.Parse(lblTeste.Text);
            objItem.QtProduto = float.Parse(txtQuantidade.Text);
            objItem.Id = ItemProdBLL.InserirItemPedBLL(objItem);
            //PedidoBLL.BuscarClienteStatusBLL();
            //ProdutoBLL.ProdutoCategoriaBLL(objProduto.IdCat);

            Close();
            /*objProduto.Nome = txtNome.Text;
            objProduto.Valor = float.Parse(txtValor.Text);
            objProduto.Descricao = txtDescricao.Text;
            Categoria selecao = (Categoria)comboBox1.SelectedItem;
            objProduto.IdCat = selecao.Id;
            objCategoria.Nome = selecao.Nome;*/
        }

        private void FrmAdcItem_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();

            string[] filtrosPesquisa = { txtCodigo.Text, txtNome.Text };

            List<Produto> Produtos = ProdutoBLL.BuscarProdutoBLL(filtrosPesquisa);
            
            Categoria objCategoria = new Categoria();

            /*foreach (var objProduto in Produtos)
            {
                string[] linhaProduto = { objCliente.Id.ToString(), objCliente.Nome, objCliente.Telefone, objCliente.Endereco, objCliente.Bairro };
                dgvClientes.Rows.Add(linhaCliente);
            }*/
            foreach (var objProduto in Produtos)
            {
                string[] linhaProduto = { objProduto.Id.ToString(), objProduto.Nome, objProduto.Valor.ToString(), objProduto.Descricao, objProduto.IdCat.ToString()
                };
                dgvProdutos.Rows.Add(linhaProduto);
            }
        }

        private void btn_Incluir_Click_1(object sender, EventArgs e)
        {
            objItem = new ItemProd();
            objProduto = new Produto();
            objCategoria = new Categoria();

            int CodigoProdutoLinhaSelecionada = int.Parse(dgvProdutos.CurrentRow.Cells["Column1_IdProduto"].Value.ToString());
            string NomeProduto = dgvProdutos.CurrentRow.Cells["Column2_NmProduto"].Value.ToString();
            float ValorProduto = float.Parse(dgvProdutos.CurrentRow.Cells["Column3_VlProduto"].Value.ToString());
            string DescricaoProduto = dgvProdutos.CurrentRow.Cells["Column4_DsProduto"].Value.ToString();
            int CodigoProdutoCatLinhaSelecionada = int.Parse(dgvProdutos.CurrentRow.Cells["Column5_IdCat"].Value.ToString());
            objItem.IdProduto = CodigoProdutoLinhaSelecionada;
            objProduto.Id = CodigoProdutoLinhaSelecionada;
            objProduto.Nome = NomeProduto;
            objProduto.Valor = ValorProduto;
            objProduto.Descricao = DescricaoProduto;
            objProduto.IdCat = CodigoProdutoCatLinhaSelecionada;
            objCategoria.Id = CodigoProdutoCatLinhaSelecionada;
            CategoriaBLL.BuscarCategoriaBLL(objCategoria.Id);

            soma = soma + objProduto.Valor;
            objItem.IdPedido = int.Parse(lblTeste.Text);
            objItem.QtProduto = float.Parse(txtQuantidade.Text);
            objItem.Id = ItemProdBLL.InserirItemPedBLL(objItem);
            //PedidoBLL.BuscarClienteStatusBLL();
            //ProdutoBLL.ProdutoCategoriaBLL(objProduto.IdCat);
            DialogResult = DialogResult.OK;
            Close();
            /*objProduto.Nome = txtNome.Text;
            objProduto.Valor = float.Parse(txtValor.Text);
            objProduto.Descricao = txtDescricao.Text;
            Categoria selecao = (Categoria)comboBox1.SelectedItem;
            objProduto.IdCat = selecao.Id;
            objCategoria.Nome = selecao.Nome;*/
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelar cadastro de itens?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
