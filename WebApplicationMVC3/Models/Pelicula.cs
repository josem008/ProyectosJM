using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMVC3.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Duracion")]
        public int Duracion { get; set; }  
       
        public string Publicacion { get; set; }
    }
}