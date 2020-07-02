using System;
using System.ComponentModel.DataAnnotations;


namespace Data.Entities
{
    public class Avaliacao : BaseEntity
    {
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
