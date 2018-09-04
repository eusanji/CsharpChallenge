using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsView.TelasCliente;

namespace WindowsFormsView
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            frmOpcoesClientes frmOpcoesClientes = new frmOpcoesClientes();
            frmOpcoesClientes.ShowDialog();
            
        }
    }
}
