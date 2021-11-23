using System;
using System.ComponentModel.DataAnnotations;

namespace TrabajoEnEquipo.Models
{
    public class Car
    {
        [Key]
        public int _idCar {get; set;}

        [Required(ErrorMessage = "Brand Car is Required")]
        [Display(Name = "BrandCar" , Prompt ="Nissan")]
        public string _brandCar {get; set;}
        
        [Required(ErrorMessage = "Model Car is Required")]
        [Display(Name = "ModelCar", Prompt ="GTR-35")]
        public string _modelCar {get; set;}
        
        [Required(ErrorMessage = "Year Car is Required")]
        [Display(Name = "YearCard", Prompt ="0000")]
        public string _yearCar {get; set;}
        
        [Required(ErrorMessage = "Color Car is Required")]
        [Display(Name = "ColorCar", Prompt ="Rojo")]
        public string _colorCar {get; set;}

        [Required(ErrorMessage = "Type Car is Required")]
        [Display(Name = "TypeCar", Prompt ="Deportivo")]
        public string _typeCar {get; set;}
    }
}