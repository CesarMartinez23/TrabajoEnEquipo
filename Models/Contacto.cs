using System;
using System.ComponentModel.DataAnnotations;

namespace TrabajoEnEquipo.Models
{
    public class Contacto
    {
        [Key]
        public int idContacto {get; set;}

        [Required(ErrorMessage = "Nombre Contacto is Required")]
        [Display(Name = "NombreContacto" , Prompt ="Yosselin")]
        public string NombreContacto {get; set;}
        
        [Required(ErrorMessage = "Apellido Contacto is Required")]
        [Display(Name = "ApellidoContacto", Prompt ="Garcia")]
        public string ApellidoContacto {get; set;}
        
        [Required(ErrorMessage = "Telefono Contacto is Required")]
        [Display(Name = "TelefonoContacto", Prompt ="+ 503 0000-0000")]
        public string TelefonoContacto {get; set;}
        
        [Required(ErrorMessage = "Direccion Contacto is Required")]
        [Display(Name = "DireccionContacto", Prompt ="San Miguel")]
        public string DireccionContacto {get; set;}
    }
}