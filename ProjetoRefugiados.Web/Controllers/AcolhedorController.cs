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
    public class AcolhedorController : Controller
    {
        AcolhedorRepository repo = new AcolhedorRepository();
        CidRepository repoCid = new CidRepository();
        // GET: Acolhedor
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        public ActionResult Index(int? id, int? ativador)
        {
            if (id != null && ativador != null)
            {
                if (ativador == 1) repo.Remove(id.Value);
                else repo.Ativar(id.Value);
            }
            return View(Mapper.Map<IEnumerable<AcolhedorViewModel>>(repo.List()));
        }

        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        [HttpPost]
        public ActionResult Index(string tipo, string id)
        {
            if (String.IsNullOrEmpty(id))
                return View(Mapper.Map<IEnumerable<AcolhedorViewModel>>(repo.ListAll()));
            if (tipo == "nome")
                return View(Mapper.Map<IEnumerable<AcolhedorViewModel>>(repo.ListNome(id)));
            return View(Mapper.Map<IEnumerable<AcolhedorViewModel>>(repo.ListCpf(id)));
        }

        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        // GET: Acolhedor/Details/5
        public ActionResult Details(int id)
        {
            return View(Mapper.Map<AcolhedorViewModel>(repo.FindById(id)));
        }

        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        // GET: Acolhedor/Create
        public ActionResult Create()
        {
            TempData["cid"] = repoCid.List().Select(x => new SelectListItem()
            {
                Text = x.Descricao,
                Value = x.CidId
            });
            return View();
        }

        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        // POST: Acolhedor/Create
        [HttpPost]
        public ActionResult Create(AcolhedorViewModel acolhedor)
        {
            if(ModelState.IsValid)
            {
                repo.Add(Mapper.Map<Acolhedor>(acolhedor));
                var acolhedorTemp = repo.ListCpf(acolhedor.Cpf);
                int id = acolhedorTemp.Where(p => p.Ativo == true).Single().AcolhedorId;
                return View("Index");
            }
            return View(acolhedor);
        }

        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        // GET: Acolhedor/Edit/5
        public ActionResult Edit(int id)
        {
            TempData["cid"] = repoCid.List().Select(x => new SelectListItem()
            {
                Text = x.Descricao,
                Value = x.CidId
            });
            return View(Mapper.Map<AcolhedorViewModel>(repo.FindById(id)));
        }

        // POST: Acolhedor/Edit/5
        [Authorize(Roles = "Administrador,Estagiario,Atendente")]
        [HttpPost]
        public ActionResult Edit(AcolhedorViewModel acolhedor)
        {
            if(!ModelState.IsValid)
            {
                repo.Edit(Mapper.Map<Acolhedor>(acolhedor));
                return RedirectToAction("Index");
            }
            return View(acolhedor);
        }

    }
}
