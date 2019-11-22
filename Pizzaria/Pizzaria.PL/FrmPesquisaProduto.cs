using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.BLL;
using Pizzaria.DTO;

namespace Pizzaria.PL
{
    public partial class FrmPesquisaProduto : Form
    {
        public Produto objProduto;
        public FrmPesquisaProduto()
        {
            InitializeComponent();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto FormCadastro = new FrmCadastroProduto(0);

            var result = FormCadastro.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaProduto = { FormCadastro.objProduto.Id.ToString(), FormCadastro.objProduto.Nome, FormCadastro.objProduto.Valor.ToString(), FormCadastro.objProduto.Descricao,FormCadastro.objCategoria.Nome
                };
                dgvProdutos.Rows.Add(linhaProduto);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int CodigoProdutoLinhaSelecionada = int.Parse(dgvProdutos.CurrentRow.Cells["Column1_IdProduto"].Value.ToString());

            FrmCadastroProduto FormCadastro = new FrmCadastroProduto(CodigoProdutoLinhaSelecionada);
            var result = FormCadastro.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaProduto = { FormCadastro.objProduto.Id.ToString(), FormCadastro.objProduto.Nome, FormCadastro.objProduto.Valor.ToString(), FormCadastro.objProduto.Descricao
                };
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].SetValues(linhaProduto);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do produto selecionado?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CodigoProdutoLinhaSelecionada = int.Parse(dgvProdutos.CurrentRow.Cells["Column1_IdProduto"].Value.ToString());

                ProdutoBLL.ExcluirProdutoBLL(CodigoProdutoLinhaSelecionada);

                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();

            string[] filtrosPesquisa = { txtCodigo.Text, txtNome.Text };

            List<Produto> Produtos = ProdutoBLL.BuscarProdutoBLL(filtrosPesquisa);

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
    }
}
