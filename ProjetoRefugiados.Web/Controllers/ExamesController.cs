using AutoMapper;
using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Repository;
using ProjetoRefugiados.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoRefugiados.Web.Controllers
{
    public class ExamesController : Controller
    {
        ExameRepository repo = new ExameRepository();
        // GET: Exames
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Administrador,Medico")]
        // GET: Exames/Create
        public ActionResult Create(int id)
        {
            TempData["id"] = id;
            return View();
        }

        // POST: Exames/Create
        [HttpPost]
        [Authorize(Roles = "Administrador,Medico")]
        public ActionResult Create(ExameViewModel model)
        {
            if(ModelState.IsValid)
            {
                repo.Add(Mapper.Map<Exame>(model));
                return RedirectToAction("Index", "Refugiado");
            }
            return View(model);
        }
    }
}
