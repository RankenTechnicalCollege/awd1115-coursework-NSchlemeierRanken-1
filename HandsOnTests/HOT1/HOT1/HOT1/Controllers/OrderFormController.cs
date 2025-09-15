using Microsoft.AspNetCore.Mvc;
using HOT1.Models;

namespace HOT1.Controllers
{
    public class OrderFormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new OrderForm());
        }

        [HttpPost]
        public IActionResult Index(OrderForm model)
        {
            if (ModelState.IsValid)
            {
                // Apply discount if a valid discount code is provided
                ApplyDiscount(model);
                return View(model);
            }
            else
            {
                // Reset DiscountMessage if ModelState validation fails
                model.DiscountMessage = string.Empty;
                return View(model);
            }
        }

        private void ApplyDiscount(OrderForm model)
        {
            // Check if a discount code is provided
            if (!string.IsNullOrWhiteSpace(model.DiscountCode))
            {
                // Apply discount based on the provided discount code
                switch (model.DiscountCode)
                {
                    case "6175":
                        model.DiscountMessage = "30% Discount Applied";
                        break;
                    case "1390":
                        model.DiscountMessage = "20% Discount Applied";
                        break;
                    case "BB88":
                        model.DiscountMessage = "10% Discount Applied";
                        break;
                    default:
                        model.DiscountMessage = "Invalid Discount Code";
                        break;
                }
            }
            else
            {
                // Reset DiscountMessage if no discount code is provided
                model.DiscountMessage = string.Empty;
            }
        }
    }
}
