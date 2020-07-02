using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public abstract class BaseEntity
    {
        [Required]
        public int ID { get; set; }
    }
}
