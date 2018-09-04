using Controllers.DAL;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    /// <summary>
    /// Esta classe é responsavel de acões do cliente 
    /// </summary>
    public class ClientesController
    {
        /// <summary>
        ///  Criando uma instância para conexao com o DB
        /// </summary>
        Contexto contexto = new Contexto();
        
        /// <summary>
        /// Cadastra um novo cliente no DB
        /// </summary>
        /// <param name="novoCliente"></param>
        public void CadastrarCliente(Cliente novoCliente)
        {
            contexto.Clientes.Add(novoCliente);
            contexto.SaveChanges();            
        }
        /// <summary>
        /// Lista todos os clientes do DB
        /// </summary>
        /// <returns></returns>
        public List<Cliente> listarTodos()
        {
            return contexto.Clientes.ToList();
        }
        /// <summary>
        /// Procura um cliente através do seu Id, no DB
        /// </summary>
        /// <param name="idcliente"></param>
        /// <returns></returns>
        public Cliente BuscarID(int idcliente)
        {
            return contexto.Clientes.Find(idcliente);
        }
        /// <summary>
        /// Exclui um cliente através do seu Id, no DB
        /// </summary>
        /// <param name="idcliente"></param>
        public void ExcluirClientesID(int idcliente)
        {
            Cliente cliente = BuscarID(idcliente);
            contexto.Clientes.Remove(cliente);
            contexto.SaveChanges();
        }

    }
}
