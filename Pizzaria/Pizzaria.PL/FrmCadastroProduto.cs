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
    public partial class FrmCadastroProduto : Form
    {
        public Categoria objCategoria;
        public Produto objProduto;

        public FrmCadastroProduto()
        {
            InitializeComponent();

        }
        
        public FrmCadastroProduto(int CodigoProduto)
        {
            InitializeComponent();


            if (CodigoProduto != 0)
            {
                objProduto = ProdutoBLL.BuscarProdutoBLL(CodigoProduto);

                txtId.Text = objProduto.Id.ToString();
                txtNome.Text = objProduto.Nome;
                txtValor.Text = objProduto.Valor.ToString();
                txtDescricao.Text = objProduto.Descricao;

            }
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (objProduto == null)
            {
                objProduto = new Produto();
                objCategoria = new Categoria();
            }

                objProduto.Nome = txtNome.Text;
            objProduto.Valor = float.Parse(txtValor.Text);
            objProduto.Descricao = txtDescricao.Text;
            Categoria selecao = (Categoria)comboBox1.SelectedItem;
            objProduto.IdCat = selecao.Id;
            objCategoria.Nome = selecao.Nome;

            if (objProduto.Id == 0)
                objProduto.Id = ProdutoBLL.InserirProdutoBLL(objProduto);
            else
                ProdutoBLL.AtualizarProdutoBLL(objProduto);

           ProdutoBLL.ProdutoCategoriaBLL(selecao.Id);
           
            DialogResult = DialogResult.OK;

            Close();
         

        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelar cadastro do produto?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
                
        }

        private void btn_IncCat_Click(object sender, EventArgs e)
        {
            FrmCadastroCategoria FormCadastro = new FrmCadastroCategoria();
            FormCadastro.ShowDialog();


        }
     

        private void btn_Recarregar_Click(object sender, EventArgs e)
        {
            List<Categoria> Categorias = CategoriaBLL.BuscarCategoriaBLL();
            foreach (var objCategoria in Categorias)
            {
                comboBox1.Items.Add(objCategoria);
            }
            comboBox1.DisplayMember = "nome";
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            List<Categoria> Categorias = CategoriaBLL.BuscarCategoriaBLL();
            foreach (var objCategoria in Categorias)
            {
                comboBox1.Items.Add(objCategoria);
            }
            comboBox1.DisplayMember = "nome";
        }
    }
}
