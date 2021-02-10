using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models.v1
{
    public class UpdateCustomerModel
    {
        [Required]
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? Birthday { get; set; }

        public int? Age { get; set; }
    }
}