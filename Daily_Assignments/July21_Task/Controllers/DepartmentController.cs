using Microsoft.AspNetCore.Mvc;
using July21_Task.Models;

namespace July21_Task.Controllers;

public class DepartmentController : Controller
{
    private static readonly Dictionary<string, Department> DepartmentStore = new()
    {
        {
            "Human Resources", new Department
            {
                DepartmentName = "Human Resources",
                DepartmentHead = "Sarah Jenkins",
                HeadContactNumber = "+15550192834",
                HeadEmail = "sjenkins@company.com"
            }
        },
        {
            "Engineering", new Department
            {
                DepartmentName = "Engineering",
                DepartmentHead = "Dr. Marcus Vance",
                HeadContactNumber = "+15550149988",
                HeadEmail = "mvance@company.com"
            }
        },
        {
            "Sales", new Department
            {
                DepartmentName = "Sales",
                DepartmentHead = "Rebecca Miller",
                HeadContactNumber = "+15550174422",
                HeadEmail = "rmiller@company.com"
            }
        },
        {
            "Marketing", new Department
            {
                DepartmentName = "Marketing",
                DepartmentHead = "Thomas Wright",
                HeadContactNumber = "+15550127711",
                HeadEmail = "twright@company.com"
            }
        }
    };

    [HttpGet]
    public IActionResult Details()
    {
        if (TempData.Peek("IsRegistered") == null || !(bool)TempData.Peek("IsRegistered")!)
        {
            TempData["WarningMessage"] = "Access Denied. You must complete employee registration to view department details.";
            return RedirectToAction("Register", "Employee");
        }

        string? employeeDept = TempData.Peek("EmployeeDept")?.ToString();
        
        if (string.IsNullOrEmpty(employeeDept) || !DepartmentStore.ContainsKey(employeeDept))
        {
            TempData["WarningMessage"] = "Could not locate department details for the registered employee.";
            return RedirectToAction("Register", "Employee");
        }

        Department department = DepartmentStore[employeeDept];

        bool isDeptModelValid = TryValidateModel(department);
        if (!isDeptModelValid)
        {
            ViewBag.ValidationStatus = "Warning: Department details failed data verification checks.";
        }
        else
        {
            ViewBag.ValidationStatus = "Verification Success: Department details are validated.";
        }

        return View(department);
    }
}
