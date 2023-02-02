﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using ContactPro.Enums;

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
        public DateTime? BirthDate { get; set; }
        [Required]
        public Countries Country { get; set; }

        [Required]
        public string? City { get; set; }
        public string? State { get; set; }
        [Required]
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        
        [Required]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; 
        }
        
        //Image properties
        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; 
        }

        //virtuals
        public virtual AppUser? AppUser { get; set; }
        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }
}
