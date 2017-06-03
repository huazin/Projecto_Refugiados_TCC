using ProjetoRefugiados.Web.Domain.Models;
using ProjetoRefugiados.Web.Infra.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels.Validadores
{
    public class ValidadorCPFAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ProjetoRefugiadosContext Db = new ProjetoRefugiadosContext();
            //  var refugiado = (RefugiadoViewModel)validationContext.ObjectInstance;
            if (String.IsNullOrEmpty(value.ToString()) ||
               value.ToString().Length != 11) return new ValidationResult("CPF não é valido");
            if ( Db.Refugiados.Where(p => p.CPF == value.ToString() && p.Ativo == true ).SingleOrDefault() != null ) return new ValidationResult("CPF já utilizado");

            return ValidadorCPF.CPFValidador(value.ToString())
                ? ValidationResult.Success
                : new ValidationResult("CPF não é valido");
                
        }
    }
}