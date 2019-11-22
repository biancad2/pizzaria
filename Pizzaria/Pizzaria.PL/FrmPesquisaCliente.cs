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
    public partial class FrmPesquisaCliente : Form
    {
        
        public FrmPesquisaCliente()
        {
            InitializeComponent();
        }
        public FrmPesquisaCliente(int Cd)
        {
            InitializeComponent();
            if (Cd == 1)
            {
                var teste = PedidoBLL.PassarClienteBLL();
                
                
                foreach (var objCliente in teste)
                {
                    string[] linhacontato = {
                    objCliente.Id.ToString(), objCliente.Nome, objCliente.Telefone,
                    objCliente.Endereco,
                   objCliente.Bairro
            };
                    dgvClientes.Rows.Add(linhacontato);
                }
                
            }
     
        }
        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente FormCadastro = new FrmCadastroCliente(0);
            var result = FormCadastro.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] linhacontato = {
                    FormCadastro.objCliente.Id.ToString(), FormCadastro.objCliente.Nome, FormCadastro.objCliente.Telefone,
                    FormCadastro.objCliente.Endereco,
                    FormCadastro.objCliente.Bairro
                };
                dgvClientes.Rows.Add(linhacontato);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do cliente selecionado?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CodigoClienteLinhaSelecionada = int.Parse(dgvClientes.CurrentRow.Cells["Column1_IdCliente"].Value.ToString());

                ClienteBLL.ExcluirClienteBLL(CodigoClienteLinhaSelecionada);

                dgvClientes.Rows.RemoveAt(dgvClientes.CurrentRow.Index);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            int CodigoClienteLinhaSelecionada = int.Parse(dgvClientes.CurrentRow.Cells["Column1_IdCliente"].Value.ToString());

            FrmCadastroCliente FormCadastro = new FrmCadastroCliente(CodigoClienteLinhaSelecionada);
            var result = FormCadastro.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] linhaCliente = { FormCadastro.objCliente.Id.ToString(), FormCadastro.objCliente.Nome, FormCadastro.objCliente.Telefone, FormCadastro.objCliente.Endereco, FormCadastro.objCliente.Bairro };
                dgvClientes.Rows[dgvClientes.CurrentRow.Index].SetValues(linhaCliente);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Editar_Click(null, null);
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();

            string[] filtrosPesquisa = { txtNome.Text, txtTelefone.Text };

            List<Cliente> Clientes = ClienteBLL.BuscarClienteBLL(filtrosPesquisa);

            foreach (var objCliente in Clientes)
            {
                string[] linhaCliente = { objCliente.Id.ToString(), objCliente.Nome, objCliente.Telefone, objCliente.Endereco, objCliente.Bairro };
                dgvClientes.Rows.Add(linhaCliente);
            }
        }

        private void FrmPesquisaCliente_Load(object sender, EventArgs e)
        {

            
            

        }
    }
}
