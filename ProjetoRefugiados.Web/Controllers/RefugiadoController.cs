using System.Web.Mvc;
using ProjetoRefugiados.Infra.Repository;
using ProjetoRefugiados.Web.ViewModels;
using AutoMapper;
using ProjetoRefugiados.Domain;
using ProjetoRefugiados.Web;
using System.Linq;
using System.Collections.Generic;

namespace ProjetoRefugiados.Web.Controllers
{
    [Authorize(Roles = "Atendente")]
    public class RefugiadoController : Controller
    {
        public readonly PacienteRepository Repo = new PacienteRepository();
        public readonly PaisRepository RepoPais = new PaisRepository();
        public readonly ProfissaoRepository RepoProf = new ProfissaoRepository();
        public readonly NascionalidadeRepository RepoNasc = new NascionalidadeRepository();
        public readonly ReligiaoRepository RepoReli = new ReligiaoRepository();

        //Tela Default Precisa mudar//
        public ActionResult Index()
        {
            return Cadastro();
        }

        public ActionResult Cadastro()
        {
            ViewBag.Pais = RepoPais.ListarPais().Select(x => new SelectListItem()
                                  {
                                      Text = x.Nome,
                                      Value = x.PaisId.ToString()
                                  });
            ViewBag.Profissao = RepoProf.ListarProfissao().Select(x => new SelectListItem()
                                  {
                                      Text = x.nome ,
                                      Value = x.ProfissaoId.ToString()
            }); ;
            ViewBag.Religiao = RepoReli.ListarReligiao().Select(x => new SelectListItem()
                                  {
                                      Text = x.Nome,
                                      Value = x.ReligiaoId.ToString() 
                                  });
            ViewBag.Nascionalidade = RepoNasc.ListarNascionalidade().Select(x => new SelectListItem()
                                  {
                                      Text = x.Nome,
                                      Value = x.NascionalidadeoId.ToString() 
                                  }); ;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PacienteViewModel PacienteVM)
        {
            if(ModelState.IsValid)
            {
                var paciente = Mapper.Map<PacienteViewModel, Paciente>(PacienteVM);
                Repo.Incluir(paciente);
                return RedirectToAction("Index");
            }
            return View("Error");
        }
    }
}