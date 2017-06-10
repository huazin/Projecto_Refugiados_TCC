using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels.Validadores
{
    public class DataAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime hoje;
            if (!DateTime.TryParse(value.ToString(), out hoje))
            {
                return new ValidationResult("Formato invalido");
            }
            hoje = Data.Hoje();
            if(Convert.ToDateTime(value.ToString()) >= hoje)
            {
                return new ValidationResult("Data invalida");
            }

            return ValidationResult.Success;

        }
    }
}