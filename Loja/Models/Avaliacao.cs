using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Avaliacao
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int Nota { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public virtual Cliente Cliente { get; set; }

        [Required]
        public Produto Produto { get; set; }

        public string Comantario { get; set; }

    }
}
