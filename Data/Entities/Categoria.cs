using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Categoria : BaseEntity
    {
        [Required, MaxLength(200)]
        public string Nome { get; set; }
        [Required]
        public byte[] ImagemHome { get; set; }
        [Required]
        public byte[] Banner { get; set; }
        public Categoria CategoriaPai { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}
