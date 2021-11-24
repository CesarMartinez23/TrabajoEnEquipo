using System;
using System.ComponentModel.DataAnnotations;

namespace TrabajoEnEquipo.Models
{
    public class Edificio
    {
      [Key] 
      public int idedificio{get; set;}
      [Required(ErrorMessage ="Nombre is requerid")]
      [Display(Name = "Nombre")]
      public string nombre_edificio{get; set;}
      [Required(ErrorMessage ="Direccion is requerid")]
      [Display(Name = "Direccion")]
      public string direccion_edificio{get; set;}
      [Required(ErrorMessage ="Cantidad is requerid")]
      [Display(Name = "Cantidad")]
      public string cantidad_oficinas{get; set;}
     
      
    }

    
    
}