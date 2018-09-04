using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsView.TelasCliente
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = txtNome.Text;
            novoCliente.Idade = int.Parse(nudCadastroIdade.Text);
            novoCliente.Telefone = mtbCadastroTelefone.Text;

            ClientesController clientesController = new ClientesController();
            clientesController.CadastrarCliente(novoCliente);

            txtNome.Text = string.Empty;
            nudCadastroIdade.Text = string.Empty;
            mtbCadastroTelefone.Text = string.Empty;

            MessageBox.Show("Cliente Cadastrado com sucesso" );
        }
    }
}
