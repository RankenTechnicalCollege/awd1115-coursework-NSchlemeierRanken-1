using System.Diagnostics;
using HOT1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HOT1.Controllers
{
    public class HomeController : Controller
    {
        // GET action method to display the Distance Converter form
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST action method to process the Distance Converter form submission
        [HttpPost]
        public IActionResult Index(DistanceConverter model)
        {
            // Check if the model state is valid
            if (ModelState.IsValid)
            {
                // Calculate the distance in centimeters based on the input distance in inches
                model.DistanceInCentimeters = model.DistanceInInches * DistanceConverter.CM_PER_IN;
                // Return the view with the updated model to display the result
                return View(model);
            }
            // If model state is not valid, return the view with the same model to display validation errors
            return View(model);
        }
    }
}
