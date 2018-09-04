using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ClientesController
    {
        Contexto contexto = new Contexto();
        //Criando uma instância para conexao com o BD

        public void CadastrarCliente(Cliente novoCliente)
        {
            contexto.Clientes.Add(novoCliente);
            contexto.SaveChanges();            
        }

        public void BuscarID()
        {

        }

        public void BuscarNome()
        {

        }

        public void ExcluirClientes()
        {

        }

    }
}
