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
    
        public int Idade { get; set; }
   
        public string Telefone { get; set; }

        [Required]
        public string Nome { get; set; }
        

    }
}
