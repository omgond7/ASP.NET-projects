using Microsoft.AspNetCore.Mvc;
using July16_Practice.Models;
namespace July16_Practice.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}