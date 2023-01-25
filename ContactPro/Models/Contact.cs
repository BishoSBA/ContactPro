﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactPro.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string? AppUserId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max {1} characters", MinimumLength = 2)]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and a max {1} characters", MinimumLength = 2)]
        public string? LastName { get; set; }
        [NotMapped]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }

        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        public string? BirthDate { get; set; }
        [Required]
        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }

    }
}