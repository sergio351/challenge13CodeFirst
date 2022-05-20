using System.ComponentModel.DataAnnotations;

namespace Challenge13CodeFirst.Models
    
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Categoria { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }


    }
}
