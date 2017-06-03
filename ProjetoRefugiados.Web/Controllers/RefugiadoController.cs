using AutoMapper;
using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Repository;
using ProjetoRefugiados.Web.ViewModels;
using RazorPDF;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoRefugiados.Web.Controllers
{
    public class RefugiadoController : Controller
    {
        public readonly RefugiadoRepository repo = new RefugiadoRepository();
        public readonly ReligiaoRepository repoReli = new ReligiaoRepository();
        public readonly NascionalidadeRepository repoNasci = new NascionalidadeRepository();
        public readonly ProfissaoRepository repoProf = new ProfissaoRepository();
        public readonly PaisRepository repoPais = new PaisRepository();
        public readonly CartaDeEncaminhamentoRepository repoCarta = new CartaDeEncaminhamentoRepository();

        [Authorize(Roles = "Atendente,Enfermeiro,Administrador,Estagiario")]
        // GET: Refugiado
        public ActionResult Index(int? id, int? ativador)
        {
            if(id != null && ativador != null)
            {
                if (ativador == 1) repo.Remove(id.Value);
                else repo.Ativar(id.Value);
            }
            return View(Mapper.Map<IEnumerable<RefugiadoViewModel>>(repo.List()));
        }

        [Authorize(Roles = "Atendente,Enfermeiro,Administrador,Estagiario")]
        [HttpPost]
        public ActionResult Index(string tipo, string id)
        {
            if (String.IsNullOrEmpty(id))
                return View(Mapper.Map<IEnumerable<RefugiadoViewModel>>(repo.ListAll()));
            if (tipo == "nome")
                return View(Mapper.Map<IEnumerable<RefugiadoViewModel>>(repo.ListNome(id)));
            return View(Mapper.Map<IEnumerable<RefugiadoViewModel>>(repo.ListCpf(id)));
        }

        [Authorize(Roles = "Atendente,Enfermeiro,Administrador,Estagiario")]
        // GET: Refugiado/Details/5
        public ActionResult Details(int id)
        {
            return View(Mapper.Map<RefugiadoViewModel>(repo.FindById(id)));
        }

        [Authorize(Roles = "Atendente,Enfermeiro,Administrador,Estagiario")]
        // GET: Refugiado/Create
        public ActionResult Create()
        {
            ViewBag.Pais = repoPais.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.PaisId.ToString()
            });
            ViewBag.Profissao = repoProf.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.ProfissaoId.ToString()
            });
            ViewBag.Religiao = repoReli.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.ReligiaoId.ToString()
            });
            ViewBag.Nascionalidade = repoNasci.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.NascionalidadeId.ToString()
            });
            return View();
        }

        [Authorize(Roles = "Atendente,Enfermeiro,Administrador,Estagiario")]
        // POST: Refugiado/Create
        [HttpPost]
        public ActionResult Create(RefugiadoViewModel refugiado)
        {
            if (ModelState.IsValid)
            {
                repo.Add(Mapper.Map<Refugiado>(refugiado));
                return RedirectToAction("Index");
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            return Create();
        }

        [Authorize(Roles = "Atendente,Enfermeiro,Administrador,Estagiario")]
        // GET: Refugiado/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Pais = repoPais.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.PaisId.ToString()
            });
            ViewBag.Profissao = repoProf.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.ProfissaoId.ToString()
            });
            ViewBag.Religiao = repoReli.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.ReligiaoId.ToString()
            });
            ViewBag.Nascionalidade = repoNasci.List().Select(x => new SelectListItem()
            {
                Text = x.Nome,
                Value = x.NascionalidadeId.ToString()
            });
            return View(Mapper.Map<RefugiadoViewModel>(repo.FindById(id)));
        }

        [Authorize(Roles = "Atendente,Enfermeiro,Administrador,Estagiario")]
        // POST: Refugiado/Edit/5
        [HttpPost]
        public ActionResult Edit(RefugiadoViewModel refugiado)
        {
            if (ModelState.IsValid)
            {
                repo.Edit(Mapper.Map<Refugiado>(refugiado));
                return RedirectToAction("Index");
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            return Edit(refugiado.RefugiadoId);
        }

        public ActionResult Imprimir(int key)
        {
            CartaDeEncaminhamento carta = repoCarta.FindById(key);
            if (carta != null)
            {
                return new ViewAsPdf(Mapper.Map<CartaDeEncaminhamentoViewModel>(carta));

            }
            return RedirectToAction("Index");

        }
        public ActionResult EncaminharPositivo(int key)
        {
            if (repoCarta.FindById(key) != null)
            {
                repoCarta.Resultado(key, 1);
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");

        }

        public ActionResult EncaminharNegativo(int key)
        {
            if (repoCarta.FindById(key) != null)
            {
                repoCarta.Resultado(key, 2);
                repoCarta.FindById(key);
                return RedirectToAction("Index");

            }
            
            return RedirectToAction("Index");

        }

        //Get Refugiado/Ativa/id


        // POST: Refugiado/Delete/5
        //[HttpPost]
        //public ActionResult Delete(RefugiadoViewModel refugiado)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        repo.Remove(Mapper.Map<Refugiado>(refugiado));
        //        return RedirectToAction("Index");
        //    }
        //    var errors = ModelState.Values.SelectMany(v => v.Errors);
        //    return RedirectToAction("Delete");
        //}
    }
}
