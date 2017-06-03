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
    public class TriagemController : Controller
    {
        public readonly RefugiadoRepository repoRefu = new RefugiadoRepository();
        public readonly TriagemRepository repoTri = new TriagemRepository();
        public readonly CidRepository repoCid = new CidRepository();

        [Authorize(Roles = "Enfermeiro,Administrador,Estagiario")]
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<RefugiadoViewModel>>(repoRefu.List()));
        }

        [Authorize(Roles = "Enfermeiro,Administrador,Estagiario")]
        public ActionResult Create(int id)
        {
            var nome = repoRefu.FindById(id).Nome;
            var sexo = repoRefu.FindById(id).Sexo;
            if (nome == null)
            {
                ViewBag.Error = "CPF não encontrado";
                return View("Index");
            }
            ViewBag.Cid = repoCid.List().Select(x => new SelectListItem()
            {
                Text = x.Descricao,
                Value = x.CidId
            });
            ViewBag.refugiado = nome;
            ViewBag.sexo = sexo;
            ViewBag.id = id;
            return View();
        }

        [Authorize(Roles = "Enfermeiro,Administrador,Estagiario")]
        [HttpPost]
        public ActionResult Create(TriagemViewModel triagem)
        {
            if(ModelState.IsValid)
            {
                repoTri.Add(Mapper.Map<Triagem>(triagem));
                return RedirectToAction("Index");
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            return View(triagem);
        }
    }
}
