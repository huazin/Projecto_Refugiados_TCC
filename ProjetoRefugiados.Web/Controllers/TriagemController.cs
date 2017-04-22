using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoRefugiados.Web.Controllers
{
    [Authorize(Roles = "Atendente")]
    public class TriagemController : Controller
    {
        // GET: Triagem
        public ActionResult Index()
        {
            return View("NovaTriagem");
        }

        public ActionResult NovaTriagem()
        {
            return View();
        }
    }
}