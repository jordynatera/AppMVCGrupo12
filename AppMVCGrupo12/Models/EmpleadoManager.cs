using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVCGrupo12.Models
{
    public class EmpleadoManager
    {
        public List<Empleado> GetEmpleados()
        {
            var lista = new List<Empleado>();
            var emp = new Empleado();

            emp.idEmpleado = 1;
            emp.nombreEmpleado = "Fulanito de Tal";
            emp.sueldoEmpleado = 5000;

            emp = new Empleado();
            emp.idEmpleado = 2;   

            lista.Add(emp);

            return lista;
        }
    }
}