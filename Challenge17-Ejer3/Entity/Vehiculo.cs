using System.ComponentModel.DataAnnotations;

namespace Challenge17_Ejer3.Entity
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Marca { get; set; }
        [Required]
        public string? Modelo { get; set; }
        [Required]
        public float? Precio { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaBaja { get; set; }


    }
}
