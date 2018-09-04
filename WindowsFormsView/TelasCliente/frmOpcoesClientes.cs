using System;
using System.Windows.Forms;

namespace WindowsFormsView.TelasCliente
{
    public partial class frmOpcoesClientes : Form
    {
        public frmOpcoesClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ao Clicar no Cadastrar novo cliente abre uma nova janela com formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog();
        }
        /// <summary>
        /// Ao Clicar no botão Excluir um clinte abre uma nova janela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnTelaExclui_Click(object sender, EventArgs e)
        {
            FrmExclui frmExclui = new FrmExclui();
            frmExclui.ShowDialog();

        }
        /// <summary>
        /// Clicar no botão Sair irá fechar a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Ao Clicar no botão Listar Clientes abre uma tela com os dados de Id e Nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            FrmListarTodos frmListarTodos = new FrmListarTodos();
            frmListarTodos.ShowDialog();
        }
        /// <summary>
        /// Ao clicar no botão Listar Clientes Ordenados abre uma tela com os dados de Id, Nome e Idade, ordenados por Idade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarClientesOrdenados_Click(object sender, EventArgs e)
        {
            FrmListarOrdenado frmListarOrdenado = new FrmListarOrdenado();
            frmListarOrdenado.ShowDialog();

        }

    }   
}
