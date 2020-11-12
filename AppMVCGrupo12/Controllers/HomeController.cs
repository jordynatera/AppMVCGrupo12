using AppMVCGrupo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVCGrupo12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Detalle()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Capturar()
        {
            Empleado emp = new Empleado
            {
                idEmpleado = 1,
                nombreEmpleado = "Jordy",
                sueldoEmpleado = 1562
            };
            return View(emp); 
        }

        [HttpPost]
        public ActionResult Capturar(FormCollection datos, Empleado empleado, EmpleadoManager manager)
        {
            /*string id = datos["idEmpleado"];
              string nombre = datos["nombreEmpleado"];
              string sueldo = datos["sueldoEmpleado"];Quiero agregar los datos del form a una lista*/
            int id = empleado.idEmpleado;
            string nombre = empleado.nombreEmpleado;
            int sueldo = empleado.sueldoEmpleado;
            ViewBag.msg = nombre;
            empleado.idEmpleado = id;
            empleado.nombreEmpleado = nombre;
            empleado.sueldoEmpleado = sueldo;
            return View(empleado);
        }

        public ActionResult ListaEmpleado()
        {
            return View();
        }

        public ActionResult Listado()
        {
            EmpleadoManager manager = new EmpleadoManager();
            var lista = manager.GetEmpleados();
            ViewBag.modelo = lista;
            return View();
        }

        public ActionResult DetalleEmpleado()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}