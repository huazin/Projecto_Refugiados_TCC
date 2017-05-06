﻿using ProjetoRefugiados.Web.Domain.Models;
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
            if ( Db.Refugiados.Where(p => p.CPF == value.ToString()).SingleOrDefault() != null ) return new ValidationResult("CPF já utilizado");
            
            return CPFValidador(value.ToString())
                ? ValidationResult.Success
                : new ValidationResult("CPF não é valido");
                
        }

        private bool CPFValidador(string cpf)
        {
            int[] tempCpf = new int[11];
            int[] Peso = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] Peso2 = new int[] {11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            for (int i = 0; i < cpf.Length; i++)
            {
                tempCpf[i] = Convert.ToInt32(cpf.Substring(i, 1));

            }
            for (int i = 0; i < Peso.Length; i++)
            {
                soma += tempCpf[i] * Peso[i];
            }
            int digito1 = (soma % 11 < 2)
                ? 0
                :  11 - (soma % 11);

            //digito 2
            int soma2 = 0;
            for (int i = 0; i < Peso2.Length; i++)
            {
                if (i < Peso2.Length - 1)
                    soma2 += tempCpf[i] * Peso2[i];
                else
                    soma2 += digito1 * Peso2[i];
            }
            int digito2 = (soma2 % 11 < 2)
                ? 0
                : 11 - (soma2 % 11);

            return (tempCpf[9] == digito1) && (tempCpf[10] == digito2)
                ? true
                : false;
        }
    }
}