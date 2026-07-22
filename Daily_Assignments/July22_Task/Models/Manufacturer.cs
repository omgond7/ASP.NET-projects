using System.ComponentModel.DataAnnotations;

namespace July22_Task.Models
{
    public class Manufacturer
    {
        [Required(ErrorMessage = "Manufacturer Name is required.")]
        [StringLength(100, ErrorMessage = "Manufacturer Name cannot exceed 100 characters.")]
        [Display(Name = "Manufacturer Name")]
        public string ManufacturerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country of origin is required.")]
        [StringLength(50, ErrorMessage = "Country name cannot exceed 50 characters.")]
        [Display(Name = "Country of Origin")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact Number is required.")]
        [Phone(ErrorMessage = "Please enter a valid telephone number.")]
        [RegularExpression(@"^\+?[0-9]{10,15}$", ErrorMessage = "Contact number must be between 10 and 15 digits (e.g. +15551234567).")]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Corporate Email Address")]
        public string EmailAddress { get; set; } = string.Empty;
    }
}
