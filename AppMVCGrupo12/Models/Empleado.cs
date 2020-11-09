using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppMVCGrupo12.Models
{
    public class Empleado
    {
        /*Tarea 2.

        Crear una aplicación que contenga las acciones de Listar , detalle y Capturar para la entidad que se muestra más abajo. 

        Entidad:

        Empleado{ Id , Nombre, Sueldo }

        La opción de capturar debe hacer un “submit” a una acción “Post”. 
        Revisa los videos sobre los “formularios”. No tienes que grabar nada, solo recibir la captura, por ahora.
         * 
         * Empleado{ Id , Nombre, Sueldo }*/
        // [Required]
        // [Display(Name = "Id del Empleado")]
        public int idEmpleado { get; set; }

        //[Required]
        //[Display(Name = "Nombre del Empleado")]
        public string nombreEmpleado { get; set; }

        //[Required]
        //[Display(Name = "Sueldo")]
        public int sueldoEmpleado { get; set; }

         
    }
}