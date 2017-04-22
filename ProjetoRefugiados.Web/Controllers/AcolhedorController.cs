using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoRefugiados.Web.Controllers
{
    [Authorize(Roles = "Atendente")]
    public class AcolhedorController : Controller
    {
        // GET: Acolhedor
        public ActionResult Index()
        {
            return View("Cadastro");
        }

        public ActionResult Cadastro()
        {
            return View();
        }
    }
}