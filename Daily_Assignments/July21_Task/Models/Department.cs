using System.ComponentModel.DataAnnotations;

namespace July21_Task.Models
{
    public class Department
    {
        [Required(ErrorMessage = "Department Name is required.")]
        [StringLength(50, ErrorMessage = "Department Name cannot exceed 50 characters.")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department Head name is required.")]
        [StringLength(100, ErrorMessage = "Department Head name cannot exceed 100 characters.")]
        [Display(Name = "Department Head")]
        public string DepartmentHead { get; set; } = string.Empty;

        [Required(ErrorMessage = "Head Contact Number is required.")]
        [Phone(ErrorMessage = "Please enter a valid telephone or mobile number.")]
        [RegularExpression(@"^\+?[0-9]{10,15}$", ErrorMessage = "Contact number must be between 10 and 15 digits (can start with +).")]
        [Display(Name = "Head Contact Number")]
        public string HeadContactNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Head Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address for the department head.")]
        [Display(Name = "Head Email")]
        public string HeadEmail { get; set; } = string.Empty;
    }
}
