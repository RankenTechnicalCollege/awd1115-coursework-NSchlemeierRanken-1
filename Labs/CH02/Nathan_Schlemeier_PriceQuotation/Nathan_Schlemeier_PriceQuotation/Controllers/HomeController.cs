using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nathan_Schlemeier_PriceQuotation.Models;

namespace Nathan_Schlemeier_PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Create a new PriceQuotationModel with default values
            var model = new PriceQuotationModel()
            {
                Subtotal = null,            // Default Subtotal set to nothing (null)
                DiscountPercent = null,     // Default DiscountPercent set to nothing (null)
                DiscountAmount = 0,         // Default DiscountAmount set to 0
                Total = 0                   // Default Total set to 0
            };
            return View(model);  // Send the data to Index for display
        }

        // Method is called when Calculate form is submitted
        [HttpPost]
        public ActionResult CalculatePriceQuotation(PriceQuotationModel model)
        {
            if (!ModelState.IsValid)    // Check if data submitted is valid
            {
                return View("Index", model);    // Return to Index view with updated data
            }
            else
            {
                model.CalculatePriceQuotation(); // Calculate based on inputted data
                return View("Index", model);
            }

        }
    }
}
