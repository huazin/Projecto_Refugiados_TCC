using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoRefugiados.Web.Controllers
{
    public class AcolhedorController : Controller
    {
        // GET: Acolhedor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Acolhedor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Acolhedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Acolhedor/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Acolhedor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Acolhedor/Edit/5
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

        // GET: Acolhedor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Acolhedor/Delete/5
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
