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
    public partial class FrmListarOrdenado : Form
    {
        public FrmListarOrdenado()
        {
            InitializeComponent();
        }

        private void frmListarOrdenado_Load(object sender, EventArgs e)
        {
            ClientesController clientesController = new ClientesController();
            List<Cliente> clientes = clientesController.listarTodos();
            dgvListaOrdenadaCliente.DataSource = clientes.Select(c => new ListarClientesOrdenadosViewModel()
                { Id = c.IdCliente, Nome = c.Nome, Idade = c.Idade,}).OrderBy(c => c.Idade).ToList();
        }
    }
}
