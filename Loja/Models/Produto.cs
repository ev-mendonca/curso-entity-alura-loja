﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Loja.Models
{
    public class Produto
    {
        [Required]
        public int ID { get; set; }
        
        [Required, MaxLength(200)]
        public string Nome { get; set; }
        
        [Required]
        public decimal PrecoUnitario { get; set; }
        
        [Required, MaxLength(2000)]
        public string BreveDescricao { get; set; }
        
        [Required]
        public string DescricaoCompleta { get; set; }
        
        [Required]
        public string Detalhes { get; set; }

        public decimal PercentualDesconto { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
