using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels.Validadores
{
    public class ValidadorCPFCartaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
            if (Db.Refugiados.Where(p => p.CPF == value.ToString() && p.Ativo == true).SingleOrDefault() == null)
                return new ValidationResult("CPF não é valido");
            return ValidationResult.Success;
        }
    }
}