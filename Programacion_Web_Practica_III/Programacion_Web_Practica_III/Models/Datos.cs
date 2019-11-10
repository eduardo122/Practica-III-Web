using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Programacion_Web_Practica_III.Models
{
    public class Datos
    {

        [Required(ErrorMessage = "Debe Completar el campo Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir un Email")]
        [EmailAddress(ErrorMessage = "Introduzca un emal valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe Completar el campo Mensaje")]
        public string Mensaje { get; set; }

    }
}