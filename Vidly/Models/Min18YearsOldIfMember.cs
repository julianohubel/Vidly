using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Models
{
    public class Min18YearsOldIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var custumer = (Customer)validationContext.ObjectInstance;

            if (custumer.MembershipTypeId == MembershipType.Unknow || custumer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (custumer.BirthDate == null)
                return new ValidationResult("Data de Nascimento é Requerida");

            int age = DateTime.Today.Year - custumer.BirthDate.Value.Year;

            return age >= 18 ? ValidationResult.Success : new ValidationResult("É necessário 18 anos ou mais para ser um membro");
            
        }


    }
}