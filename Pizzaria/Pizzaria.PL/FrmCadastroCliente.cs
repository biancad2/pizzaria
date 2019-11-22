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
    public partial class FrmCadastroCliente : Form
    {
        public Cliente objCliente;
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }
        public FrmCadastroCliente(int CodigoCliente)
        {
            InitializeComponent();

            if (CodigoCliente != 0)
            {
                objCliente = ClienteBLL.BuscarClienteBLL(CodigoCliente);
                txtId.Text = objCliente.Id.ToString();
                txtNome.Text = objCliente.Nome;
                txtTelefone.Text = objCliente.Telefone;
                txtEndereco.Text = objCliente.Endereco;
                txtBairro.Text = objCliente.Bairro;
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (objCliente == null)
                objCliente = new Cliente();
            objCliente.Nome = txtNome.Text;
            objCliente.Telefone = txtTelefone.Text;
            objCliente.Endereco = txtEndereco.Text;
            objCliente.Bairro = txtBairro.Text;

            if (objCliente.Id == 0)
                objCliente.Id = ClienteBLL.InserirClienteBLL(objCliente);
            else
                ClienteBLL.AtualizarClienteBLL(objCliente);

            DialogResult = DialogResult.OK;

            Close();

        }
    }
}
