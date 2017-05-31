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
    public class OportunidadeController : Controller
    {
        OportunidadeRepository repo = new OportunidadeRepository();
        // GET: Oportunidade
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<OportunidadeViewModel>>(repo.ListVagos()));
        }

        [HttpPost]
        public ActionResult Index(string tipo, string id)
        {
            if (String.IsNullOrEmpty(id))
                return View(Mapper.Map<IEnumerable<OportunidadeViewModel>>(repo.List()));
            if (tipo == "nome")
                return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repo.ListTitulo(id)));
            return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repo.ListEmpresa(id)));
        }
        // GET: Oportunidade/Details/5
        public ActionResult Details(int id)
        {
            return View(Mapper.Map<OportunidadeViewModel>(repo.FindById(id)));
        }

        // GET: Oportunidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Oportunidade/Create
        [HttpPost]
        public ActionResult Create(OportunidadeViewModel oportunidade)
        {
            if(ModelState.IsValid)
            {
                repo.Add(Mapper.Map<Oportunidade>(oportunidade));
                return RedirectToAction("Index");
            }
            return View(oportunidade);
        }

        // GET: Oportunidade/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Mapper.Map<OportunidadeViewModel>(repo.FindById(id)));
        }

        // POST: Oportunidade/Edit/5
        [HttpPost]
        public ActionResult Edit(OportunidadeViewModel oportunidade)
        {
            if (ModelState.IsValid)
            {
                repo.Edit(Mapper.Map<Oportunidade>(oportunidade));
                return RedirectToAction("Index");
            }
            return View(oportunidade);
        }
    }
}
