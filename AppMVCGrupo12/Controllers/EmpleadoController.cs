using AppMVCGrupo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVCGrupo12.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        // GET: Empleado/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, Empleado empleado)
        {
            try
            {
                // TODO: Add insert logic here
                /*string id = collection["idEmpleado"];
                 string nombre = collection["nombreEmpleado"];
                 string sueldo = collection["sueldoEmpleado"];*/
                int id = empleado.idEmpleado;
                string nombre = empleado.nombreEmpleado;
                int sueldo = empleado.sueldoEmpleado;
                @ViewBag.msg = id;
                return View();
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleado/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
