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



        [HttpGet]
        public ActionResult Capturar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Capturar(FormCollection datos, Empleado empleado)
        {
            string id = datos["idEmpleado"];
            string nombre = datos["nombreEmpleado"];
            string sueldo = datos["sueldoEmpleado"];
            ViewBag.msg = "Id = " + id + "       Nombre " + nombre + "      Sueldo " + sueldo;
            //string value = Convert.ToString(collection["inputName"]);

            return View();
        }

        public ActionResult Create(FormCollection collection)
        {
            string id = collection["idEmpleado"];
            string nombre = collection["nombreEmpleado"];
            string sueldo = collection["sueldoEmpleado"];
            ViewBag.msg = "Id = " + id + "       Nombre " + nombre + "      Sueldo " + sueldo;

            var lista = new List<Empleado>();
            var emp = new Empleado();

            emp.idEmpleado = id;
            emp.nombreEmpleado = nombre;
            emp.sueldoEmpleado = sueldo;

            lista.Add(emp);

            return RedirectToAction("Listado", emp);
        }

        public ActionResult Listar()
        {
            EmpleadoManager manager = new EmpleadoManager();
            var lista = manager.GetEmpleados();
            ViewBag.modelo = lista;
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Listado(Empleado reg)
        {
            EmpleadoManager manager = new EmpleadoManager();
            var lista = manager.GetEmpleados();
            ViewBag.modelo = lista;
            return View(reg);
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