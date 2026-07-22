using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using July22_Task.Models;

namespace July22_Task.Controllers;

public class AutomobileController : Controller
{
    private List<SelectListItem> GetFuelTypes()
    {
        return new List<SelectListItem>
        {
            new SelectListItem { Value = "Petrol", Text = "Petrol" },
            new SelectListItem { Value = "Diesel", Text = "Diesel" },
            new SelectListItem { Value = "Electric", Text = "Electric" },
            new SelectListItem { Value = "Hybrid", Text = "Hybrid" }
        };
    }

    [HttpGet]
    public IActionResult Register()
    {
        ViewBag.FuelTypes = GetFuelTypes();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Automobile automobile)
    {
        if (ModelState.IsValid)
        {
            TempData["AutoRegistered"] = true;
            TempData["RegisteredVehicleName"] = automobile.VehicleName;
            TempData["RegisteredBrand"] = automobile.Brand;

            ViewBag.SuccessMessage = "Automobile Registered Successfully";
            ViewBag.ShowSuccess = true;

            ViewBag.FuelTypes = GetFuelTypes();
            return View(automobile);
        }

        ViewBag.FuelTypes = GetFuelTypes();
        return View(automobile);
    }
}
