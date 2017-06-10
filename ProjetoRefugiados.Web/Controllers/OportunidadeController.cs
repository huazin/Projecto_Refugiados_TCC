using AutoMapper;
using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Repository;
using ProjetoRefugiados.Web.ViewModels;
using RazorPDF;
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
        CartaDeEncaminhamentoRepository repoCarta = new CartaDeEncaminhamentoRepository();
        RefugiadoRepository repoRefu = new RefugiadoRepository();
        // GET: Oportunidade
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Index(int? id, int? ativador)
        {
            if (id != null && ativador != null)
            {
                if (ativador == 1) repo.Remove(id.Value);
                else repo.Ativar(id.Value);
            }
            return View(Mapper.Map<IEnumerable<OportunidadeViewModel>>(repo.ListVagos()));
        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Index(string tipo, string id)
        {
            if (String.IsNullOrEmpty(id))
                return View(Mapper.Map<IEnumerable<OportunidadeViewModel>>(repo.List()));
            if (tipo == "nome")
                return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repo.ListTitulo(id)));
            return View(Mapper.Map<IEnumerable<ProjetoViewModel>>(repo.ListEmpresa(id)));
        }
        // GET: Oportunidade/Details/5
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Details(int id)
        {
            return View(Mapper.Map<OportunidadeViewModel>(repo.FindById(id)));
        }

        // GET: Oportunidade/Create
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Create(int id)
        {
            TempData["id"] = id;
            return View();
        }

        // POST: Oportunidade/Create
        [HttpPost]
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Create(OportunidadeViewModel oportunidade)
        {
            if(ModelState.IsValid)
            {
                repo.Add(Mapper.Map<Oportunidade>(oportunidade));
                return RedirectToAction("Index");
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            return View(oportunidade);
        }

        // GET: Oportunidade/Edit/5
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Edit(int id)
        {
            return View(Mapper.Map<OportunidadeViewModel>(repo.FindById(id)));
        }

        // POST: Oportunidade/Edit/5
        [HttpPost]
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Edit(OportunidadeViewModel oportunidade)
        {
            if (ModelState.IsValid)
            {
                repo.Edit(Mapper.Map<Oportunidade>(oportunidade));
                return RedirectToAction("Index");
            }
            return View(oportunidade);
        }
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult CartaDeEncaminhamento(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult CartaDeEncaminhamento(CartaDeEncaminhamentoViewModel carta)
        {
            if(ModelState.IsValid)
            {
                carta.RefugiadoId = repoRefu.FindByCPF(carta.CPF).RefugiadoId;
                repoCarta.Add(Mapper.Map<CartaDeEncaminhamento>(carta));
                return RedirectToAction("Details/" + carta.RefugiadoId, "Refugiado");
            }
            return View(carta);
        }
    }
}
