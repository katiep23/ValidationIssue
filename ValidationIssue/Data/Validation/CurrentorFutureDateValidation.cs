using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ValidationIssue.Data.Validation
{
    class CurrentOrFutureDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }
            DateTime dt = (DateTime)value;
            if (dt >= DateTime.Today)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "Date selected must be greater or equal to today's date.");
        }
    }
}
