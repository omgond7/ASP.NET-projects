using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using July21_Task.Models;

namespace July21_Task.Controllers;

public class EmployeeController : Controller
{
    private List<SelectListItem> GetDepartments()
    {
        return new List<SelectListItem>
        {
            new SelectListItem { Value = "Human Resources", Text = "Human Resources" },
            new SelectListItem { Value = "Engineering", Text = "Engineering" },
            new SelectListItem { Value = "Sales", Text = "Sales" },
            new SelectListItem { Value = "Marketing", Text = "Marketing" }
        };
    }

    [HttpGet]
    public IActionResult Register()
    {
        ViewBag.Departments = GetDepartments();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Employee employee)
    {
        if (ModelState.IsValid)
        {
            TempData["EmployeeName"] = employee.EmployeeName;
            TempData["EmployeeDept"] = employee.Department;
            TempData["IsRegistered"] = true;

            return RedirectToAction(nameof(Success));
        }

        ViewBag.Departments = GetDepartments();
        return View(employee);
    }

    [HttpGet]
    public IActionResult Success()
    {
        if (TempData.Peek("IsRegistered") == null || !(bool)TempData.Peek("IsRegistered")!)
        {
            TempData["WarningMessage"] = "Please register an employee first.";
            return RedirectToAction(nameof(Register));
        }

        return View();
    }
}
