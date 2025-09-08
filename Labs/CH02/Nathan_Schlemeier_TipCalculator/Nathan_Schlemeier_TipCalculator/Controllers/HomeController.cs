using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nathan_Schlemeier_TipCalculator.Models;

namespace Nathan_Schlemeier_TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new TipCalculatorModel());
        }

        [HttpPost]
        public IActionResult Calculate(TipCalculatorModel model, decimal tipPercentage)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            // Calculate tip amounts for fixed percentages
            decimal tipAmountFor15Percent = model.MealCost * 0.15m;
            decimal tipAmountFor20Percent = model.MealCost * 0.20m;
            decimal tipAmountFor25Percent = model.MealCost * 0.25m;

            // Store tip amounts in ViewBag or ViewData
            ViewBag.TipAmountFor15Percent = tipAmountFor15Percent;
            ViewBag.TipAmountFor20Percent = tipAmountFor20Percent;
            ViewBag.TipAmountFor25Percent = tipAmountFor25Percent;

            // Return the view with the updated model to display the tip amounts
            return View("Index", model);
        }
    }
}
