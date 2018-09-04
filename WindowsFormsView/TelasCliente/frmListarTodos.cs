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
    public partial class FrmListarTodos : Form
    {
        public FrmListarTodos()
        {
            InitializeComponent();
        }

        private void frmListarTodos_Load(object sender, EventArgs e)
        {
            ClientesController clientesController = new ClientesController();
            List<Cliente> clientes = clientesController.listarTodos();
            dgvListarClientes.DataSource = clientes.Select(c => new ListarTodosViewModel() { Id = c.IdCliente, Nome = c.Nome }).ToList();
        }
    }
}
