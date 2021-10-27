using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }

        public int Stock { get; set; }
    }
}
