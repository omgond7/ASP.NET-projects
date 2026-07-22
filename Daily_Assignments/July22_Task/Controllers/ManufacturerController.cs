using Microsoft.AspNetCore.Mvc;
using July22_Task.Models;

namespace July22_Task.Controllers;

public class ManufacturerController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        if (TempData.Peek("AutoRegistered") == null || !(bool)TempData.Peek("AutoRegistered")!)
        {
            TempData["WarningMessage"] = "Access Denied. You must complete automobile registration first.";
            return RedirectToAction("Register", "Automobile");
        }

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(Manufacturer manufacturer)
    {
        if (TempData.Peek("AutoRegistered") == null || !(bool)TempData.Peek("AutoRegistered")!)
        {
            TempData["WarningMessage"] = "Session expired or invalid automobile registered state.";
            return RedirectToAction("Register", "Automobile");
        }

        if (ModelState.IsValid)
        {
            TempData["MfgName"] = manufacturer.ManufacturerName;
            TempData["MfgCountry"] = manufacturer.Country;
            TempData["MfgContact"] = manufacturer.ContactNumber;
            TempData["MfgEmail"] = manufacturer.EmailAddress;
            TempData["MfgRegistered"] = true;

            return RedirectToAction(nameof(Details));
        }

        return View(manufacturer);
    }

    [HttpGet]
    public IActionResult Details()
    {
        if (TempData.Peek("AutoRegistered") == null || !(bool)TempData.Peek("AutoRegistered")!)
        {
            TempData["WarningMessage"] = "Please register an automobile first.";
            return RedirectToAction("Register", "Automobile");
        }

        if (TempData.Peek("MfgRegistered") == null || !(bool)TempData.Peek("MfgRegistered")!)
        {
            TempData["WarningMessage"] = "Please complete manufacturer registration first.";
            return RedirectToAction(nameof(Register));
        }

        var manufacturer = new Manufacturer
        {
            ManufacturerName = TempData.Peek("MfgName")?.ToString() ?? "Unknown",
            Country = TempData.Peek("MfgCountry")?.ToString() ?? "Unknown",
            ContactNumber = TempData.Peek("MfgContact")?.ToString() ?? "Unknown",
            EmailAddress = TempData.Peek("MfgEmail")?.ToString() ?? "Unknown"
        };

        return View(manufacturer);
    }
}
