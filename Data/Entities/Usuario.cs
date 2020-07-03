using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
    public class Usuario : BaseEntity
    {
        [Required, MaxLength(255)]
        public string Nome { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
