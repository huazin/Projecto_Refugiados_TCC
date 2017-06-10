using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoRefugiados.Web.ViewModels.Validadores
{
    public class SomenteLetrasAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null) return new ValidationResult("Nome é obrigatorio");
            var texto = value.ToString();

            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-1234567890" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            int index = texto.IndexOfAny(specialCharactersArray);
            //index == -1 no special characters
            if (index == -1)
                return ValidationResult.Success;
            else
                return new ValidationResult("Não é permitido caracteres especiais ou numeros");
        }
    }
}