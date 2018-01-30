using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomeworkDay1.Models.Valid
{
    public class ValidDateTodayAttribute: ValidationAttribute
    {
        /*protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dt = (DateTime)value;
            if (dt <= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "Make sure your date is <= than today");
        }*/
        public override bool IsValid(object value)
        {
            if(value == null) return false;
            DateTime dt = (DateTime)value;
            return dt <= DateTime.Now;
           
        }
    }
}