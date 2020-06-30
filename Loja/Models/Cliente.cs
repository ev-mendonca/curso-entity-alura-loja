using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Cliente
    {
        [Required]
        public int ID { get; set; }
        [Required, MaxLength(200)]
        public string Nome { get; set; }
        [Required, MaxLength(200)]
        public string Email { get; set; }
        
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
