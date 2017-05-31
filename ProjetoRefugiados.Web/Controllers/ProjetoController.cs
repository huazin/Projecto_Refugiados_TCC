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
    public class ProjetoController : Controller
    {
        ProjetoRepository repoPro = new ProjetoRepository();
        // GET: Projeto
        public ActionResult Index(int? id, int? ativador)
        {
            if (id != null && ativador != null)
            {
                if (ativador == 1) repoPro.Remove(id.Value);
                else repoPro.Ativar(id.Value);
            }
            return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repoPro.List()));
        }

        [HttpPost]
        public ActionResult Index(string tipo, string id)
        {
            if (String.IsNullOrEmpty(id))
                return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repoPro.ListAll()));
            if (tipo == "nome")
                return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repoPro.ListNome(id)));
            return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repoPro.ListCnpj(id)));
        }

        // GET: Projeto/Details/5
        public ActionResult Details(int id)
        {
            return View(Mapper.Map<ProjetoViewModel>(repoPro.FindById(id)));
        }

        // GET: Projeto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projeto/Create
        [HttpPost]
        public ActionResult Create(ProjetoViewModel projeto)
        {
            if(ModelState.IsValid)
            {
                repoPro.Add(Mapper.Map<Projeto>(projeto));
                return RedirectToAction("Index");
            }
            return View(projeto);
        }

        // GET: Projeto/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Mapper.Map<ProjetoViewModel>(repoPro.FindById(id)));
        }

        // POST: Projeto/Edit/5
        [HttpPost]
        public ActionResult Edit(Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                repoPro.Edit(Mapper.Map<Projeto>(projeto));
                return RedirectToAction("Index");
            }
            return View(projeto);
        }
    }
}
