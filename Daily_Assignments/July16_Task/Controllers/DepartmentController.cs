using Microsoft.AspNetCore.Mvc;
using July16_Task.Models;

namespace July16_Task.Controllers;

public class DepartmentController : Controller
{
    public IActionResult Index()
    {
        List<Department> departments = new List<Department>
        {
            new Department { Name = "IT", DepartmentHead = "Amit Kumar", HeadContact = "+1-555-0199", HeadEmail = "amit.kumar@example.com" },
            new Department { Name = "HR", DepartmentHead = "Priya Sharma", HeadContact = "+1-555-0122", HeadEmail = "priya.sharma@example.com" },
            new Department { Name = "Finance", DepartmentHead = "Rahul Singh", HeadContact = "+1-555-0144", HeadEmail = "rahul.singh@example.com" },
            new Department { Name = "Marketing", DepartmentHead = "Sneha Patel", HeadContact = "+1-555-0177", HeadEmail = "sneha.patel@example.com" },
            new Department { Name = "Sales", DepartmentHead = "Karan Johar", HeadContact = "+1-555-0188", HeadEmail = "karan.johar@example.com" }
        };
        return View(departments);
    }
}
