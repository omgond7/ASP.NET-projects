using System.ComponentModel.DataAnnotations;

namespace July22_Task.Models
{
    public class Automobile
    {
        [Required(ErrorMessage = "Vehicle ID is required.")]
        [RegularExpression(@"^[A-Z]{3}-\d{3}$", ErrorMessage = "Vehicle ID must be in format 'AAA-123' (3 uppercase letters, a dash, and 3 numbers).")]
        [Display(Name = "Vehicle ID")]
        public string VehicleId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vehicle Name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Vehicle Name must be between 2 and 50 characters.")]
        [Display(Name = "Vehicle Name")]
        public string VehicleName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Brand name is required.")]
        [StringLength(50, ErrorMessage = "Brand name cannot exceed 50 characters.")]
        [Display(Name = "Brand / Manufacturer")]
        public string Brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "Model Year is required.")]
        [Range(1900, 2027, ErrorMessage = "Model Year must be between 1900 and 2027.")]
        [Display(Name = "Model Year")]
        public int? ModelYear { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(1.00, 10000000.00, ErrorMessage = "Price must be between $1.00 and $10,000,000.00.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Retail Price")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Please select a fuel type.")]
        [Display(Name = "Fuel Type")]
        public string FuelType { get; set; } = string.Empty;
    }
}
