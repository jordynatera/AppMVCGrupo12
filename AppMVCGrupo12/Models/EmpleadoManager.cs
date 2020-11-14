using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVCGrupo12.Controllers;

namespace AppMVCGrupo12.Models
{
    public class EmpleadoManager
    {
        public List<Empleado> GetEmpleados()
        {
            var lista = new List<Empleado>();
            var emp = new Empleado();
            HomeController homeController = new HomeController();

            emp.idEmpleado ="1";
            emp.nombreEmpleado = "Fulanito de Tal";
            emp.sueldoEmpleado = "5000";
            lista.Add(emp);

            emp = new Empleado();
            emp.idEmpleado = "2";
            emp.nombreEmpleado = "Jordy";
            emp.sueldoEmpleado = "1400";
            lista.Add(emp);

            emp = new Empleado();
            emp.idEmpleado = "3";
            emp.nombreEmpleado = "Preso #9";
            emp.sueldoEmpleado = "1300"; 
            lista.Add(emp);

            return lista;
        }
    }
}