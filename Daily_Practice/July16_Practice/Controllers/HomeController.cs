using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using July16_Practice.Models;

namespace July16_Practice.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 101, Name = "abc", Age = 20, Course = "Dot Net Framework" },
            new Student { Id = 102, Name = "abc", Age = 20, Course = "Dot Net Framework" },
            new Student { Id = 101, Name = "abc", Age = 20, Course = "Dot Net Framework" },
            new Student { Id = 101, Name = "abc", Age = 20, Course = "Dot Net Framework" }
        };
        return View(students);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
