using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoRefugiados.Web.Controllers
{
    public class AdmController : Controller
    {
        // GET: Adm
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult NovoFuncionario()
        {
            return View();
        }
    }
}