using System.ComponentModel.DataAnnotations;

namespace July21_Task.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee ID is required.")]
        [RegularExpression(@"^EMP-\d{4}$", ErrorMessage = "Employee ID must follow the pattern 'EMP-XXXX' (e.g., EMP-1024).")]
        [Display(Name = "Employee ID")]
        public string EmployeeId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee Name is required.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Employee Name must be between 3 and 100 characters.")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a department.")]
        [Display(Name = "Department")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Salary is required.")]
        [Range(1000.00, 10000000.00, ErrorMessage = "Salary must be between $1,000 and $10,000,000.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Salary")]
        public decimal? Salary { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;
    }
}
