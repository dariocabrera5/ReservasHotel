using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Docs.Models
{
    public class Hoteles
    {
        [Key]
        public int Id {set;get;}
        [Required]
        public string? HabitacionPremium {get;set;}
        [Required]
        public string? HabitacionStandar {get;set;}
        [Required]
        public string? CupoHabitacion {get;set;}
        [Required]
        public string? Ciudad {get; set;}
    }
}