using Controllers;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsView.TelasCliente
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ao clicar em Salvar o mesmo realiza o cadastro dos dados fornecidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(null) || txtNome.Text.Equals("") ||
                (int.Parse(nudCadastroIdade.Text).Equals(null) || int.Parse(nudCadastroIdade.Text).Equals("") || int.Parse(nudCadastroIdade.Text) <= 0) || 
                mtbCadastroTelefone.Text.Equals(null) || mtbCadastroTelefone.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
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

                MessageBox.Show("Cliente Cadastrado com sucesso");
            }

        }
        /// <summary>
        /// Ao clicar em Cancelar ou Sair o mesmo fecha a tela do formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastroSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Ao clicar no botão Limpar o mesmo apaga os dados do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            nudCadastroIdade.Text = string.Empty;           
            mtbCadastroTelefone.Text = string.Empty;
        }
    }
}
