using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Cliente : BaseEntity
    {

        [Required, MaxLength(200)]
        public string Nome { get; set; }
        [Required, MaxLength(200)]
        public string Email { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
