using System;
using System.ComponentModel.DataAnnotations;

namespace TrabajoEnEquipo.Models
{
    public class Student
    {
        //definir propiedades
        [Key]
        public int CodStudent {get; set;}
         [Required(ErrorMessage ="El Nombre es requerido")]
        [Display(Name ="Nombre")]
        
 
        public string Nombre {get; set;}
         [Required(ErrorMessage ="El apellido es requerido")]
         [Display(Name ="Apellido")]
       
        public string Apellido {get; set;}
        
        public string CorreoElectronico {get; set;}
        [Required(ErrorMessage ="El Genéro es requerido")]
         [Display(Name ="Genéro")]
        public string Genero {get; set;}
         [Required(ErrorMessage ="La edad es requerida")]
        [Display(Name ="Edad")]
        public string edad {get; set;}
         [Required(ErrorMessage ="La dirección es requerida")]
        [Display(Name ="Dirección")]
        public string Direccion {get; set;}
       [Required(ErrorMessage ="El grado es requerido")]
        [Display(Name ="Grado")]
        public string Grado {get; set;}
         [Required(ErrorMessage ="La sección es requierida")]
        [Display(Name ="Sección")]
        [StringLength(100)]
        public string Seccion {get; set;}
       
    }

    


}