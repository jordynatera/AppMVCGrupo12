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
            return View();
        }

        [HttpPost]
        public ActionResult Capturar(FormCollection datos, Empleado empleado)
        {
            /*string id = datos["idEmpleado"];
              string nombre = datos["nombreEmpleado"];
              string sueldo = datos["sueldoEmpleado"];*/
            int id = empleado.idEmpleado;
            string nombre = empleado.nombreEmpleado;
            int sueldo = empleado.sueldoEmpleado;
            ViewBag.msg = nombre;
            return View(empleado);
        }

        public ActionResult ListaEmpleado()
        {
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