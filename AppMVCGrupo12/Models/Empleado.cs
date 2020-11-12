using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppMVCGrupo12.Models
{
    public class Empleado
    {

        public int idEmpleado { get; set; }

        public string nombreEmpleado { get; set; }

        public int sueldoEmpleado { get; set; }

         
    }
}