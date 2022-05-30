using System.ComponentModel.DataAnnotations;

namespace Challenge17_Ejer3.Entity
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellido { get; set; }
       
        [Required]
        public int? Dni { get; set; }
        
        
        [Required]
        public string? Direccion { get; set; }
    }
}
