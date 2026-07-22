using Microsoft.AspNetCore.Mvc;
using July16_Task.Models;

namespace July16_Task.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1001, Name = "Amit Kumar", Department = "IT", Salary = 75000, Email = "amit.kumar@example.com" },
            new Employee { EmployeeId = 1002, Name = "Priya Sharma", Department = "HR", Salary = 60000, Email = "priya.sharma@example.com" },
            new Employee { EmployeeId = 1003, Name = "Rahul Singh", Department = "Finance", Salary = 80000, Email = "rahul.singh@example.com" },
            new Employee { EmployeeId = 1004, Name = "Sneha Patel", Department = "Marketing", Salary = 55000, Email = "sneha.patel@example.com" },
            new Employee { EmployeeId = 1005, Name = "Karan Johar", Department = "Sales", Salary = 65000, Email = "karan.johar@example.com" }
        };
        return View(employees);
    }
}
