using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsView.TelasCliente
{
    public partial class FrmExclui : Form
    {
        public FrmExclui()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ao clicar no botão Excluir haverá validações e e seleciona o Id atraves do campo txtExclui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (txtExcluiClienteId.Text.Equals(null) || int.Parse(txtExcluiClienteId.Text) <= 0)
            {
                MessageBox.Show("Prencha todos os campos");
            }
            else
            {
                Cliente excluiCliente = new Cliente
                {
                    IdCliente = int.Parse(txtExcluiIdNome.Text)
                };
                             
                ClientesController clientesController = new ClientesController();
                clientesController.ExcluirClientesID(excluiCliente.IdCliente);
                MessageBox.Show("Cliente excluido com sucesso");
                txtExcluiIdNome.Clear();
            }
        }
        /// <summary>
        /// Ao clicar no botão Buscar, retorna dados de um Id no Quadro abaixo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluiBuscar_Click(object sender, EventArgs e)
        {
            if (txtExcluiClienteId.Text.Equals(null) || int.Parse(txtExcluiClienteId.Text) <= 0)
            {
                MessageBox.Show("Favor digitar um dado no campo Digite o ID");
            }
            else
            {
                ClientesController clientesController = new ClientesController();
                Cliente cliente = clientesController.BuscarID(int.Parse(txtExcluiClienteId.Text));
                List<Cliente> clienteList = new List<Cliente>();
                clienteList.Add(cliente);
                dgvExcluirCliente.DataSource = clienteList;

                MessageBox.Show("Cliente excluido com Sucesso");           
            }
        }
        /// <summary>
        /// Ao clicar no botão Cancelar ou Sair o mesmo fecha a tela 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluiSairCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
