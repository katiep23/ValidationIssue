using System;
using System.ComponentModel.DataAnnotations;
using ValidationIssue.Data.Validation;

namespace ValidationIssue.Data
{
    public class Project
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Request By Date")]
        [CurrentOrFutureDateValidation]
        public DateTime? RequestedByDate { set; get; }
    }
}
