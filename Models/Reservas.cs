using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Docs.Models
{
    public class Reservas
    {
        [Key]
        public int Id;
        [DataType(DataType.DateTime)]
        public DateTime? Fecha {get;set;}
        [Required]
        public string? Ciudad {get; set;}
        public string? TipoHabitacion {get; set;}        
    }
}