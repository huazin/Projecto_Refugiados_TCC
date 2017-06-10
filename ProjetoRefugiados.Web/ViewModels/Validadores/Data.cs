using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels.Validadores
{
    public class Data
    {
        public static DateTime Hoje()
        {
            string hoje = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            return Convert.ToDateTime(hoje);
        }

        public static DateTime Hoje5Meses()
        {
            string hoje;
            if (DateTime.Now.Month < 5)
            {
                hoje = (DateTime.Now.Year - 1) + "-" + (12 - 4) + "-" + DateTime.Now.Day;
            }
            hoje = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            return Convert.ToDateTime(hoje);
        }
    }
}