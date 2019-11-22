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
    public partial class FrmCadastroCategoria : Form
    {
        public Categoria objCategoria;
        public FrmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (objCategoria == null)
                objCategoria = new Categoria();
            objCategoria.Nome = txtNome.Text;
            objCategoria.Descricao = txtDescricao.Text;

            if (objCategoria.Id == 0)
                objCategoria.Id = CategoriaBLL.InserirCategoriaBLL(objCategoria);
            else
                CategoriaBLL.AtualizarCategoriaBLL(objCategoria);

            string[] linhaCategoria = { objCategoria.Id.ToString(), objCategoria.Nome, objCategoria.Descricao };
            dgvCategoria.Rows.Add(linhaCategoria);
            
        }

        private void FrmCadastroCategoria_Load(object sender, EventArgs e)
        {
            List<Categoria> Categorias = CategoriaBLL.BuscarCategoriaBLL();
            foreach (var objCategoria in Categorias)
            {
                string[] linhaCategoria = { objCategoria.Id.ToString(), objCategoria.Nome, objCategoria.Descricao };
                dgvCategoria.Rows.Add(linhaCategoria);
            }
          
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão da categoria selecionada?", "Excluir Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CodigoCatLinhaSelecionada = int.Parse(dgvCategoria.CurrentRow.Cells["Column1_IdCat"].Value.ToString());

                CategoriaBLL.ExcluirCategoriaBLL(CodigoCatLinhaSelecionada);

                dgvCategoria.Rows.RemoveAt(dgvCategoria.CurrentRow.Index);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int CodigoCatLinhaSelecionada = int.Parse(dgvCategoria.CurrentRow.Cells["Column1_IdCat"].Value.ToString());

            objCategoria = CategoriaBLL.BuscarCategoriaBLL(CodigoCatLinhaSelecionada);

            txtId.Text = objCategoria.Id.ToString();
            txtNome.Text = objCategoria.Nome;
            txtDescricao.Text = objCategoria.Descricao;

        }
  
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (objCategoria == null)
                objCategoria= new Categoria();

            objCategoria.Nome = txtNome.Text;
            objCategoria.Descricao = txtDescricao.Text;
     
            if (objCategoria.Id == 0)
                objCategoria.Id = CategoriaBLL.InserirCategoriaBLL(objCategoria);
            else
                CategoriaBLL.AtualizarCategoriaBLL(objCategoria);

            dgvCategoria.Rows.Clear();
            List<Categoria> Categorias = CategoriaBLL.BuscarCategoriaBLL();
            foreach (var objCategoria in Categorias)
            {
                string[] linhaCategoria = { objCategoria.Id.ToString(), objCategoria.Nome, objCategoria.Descricao };
                dgvCategoria.Rows.Add(linhaCategoria);
            }
            txtId.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtNome.Focus();

        }
    }
}
