using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        private int idade;
        public int Idade { get; set; }
        private string telefone;
        public string Telefone { get; set; }

        [Required]
        public string Nome { get; set; }
        

    }
}
