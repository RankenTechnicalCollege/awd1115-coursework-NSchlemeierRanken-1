using System.ComponentModel.DataAnnotations;

namespace HOT1.Models
{
    public class OrderForm
    {
        // Constants
        private const decimal DefaultPricePerShirt = 15.00m;

        // Properties
        [Required(ErrorMessage = "Please enter a quantity.")]
        public int Quantity { get; set; }

        // Discount code is optional
        public string? DiscountCode { get; set; }

        public string? DiscountMessage { get; set; }

        // Calculated properties
        public decimal PricePerShirt => DefaultPricePerShirt;

        public decimal DiscountedPricePerShirt
        {
            get
            {
                // Calculate discounted price based on the discount code
                decimal discountedPrice = PricePerShirt;
                switch (DiscountCode)
                {
                    case "6175":
                        discountedPrice *= 0.7m; // 30% discount
                        break;
                    case "1390":
                        discountedPrice *= 0.8m; // 20% discount
                        break;
                    case "BB88":
                        discountedPrice *= 0.9m; // 10% discount
                        break;
                    default:
                        break;
                }
                return discountedPrice;
            }
        }

        public decimal Subtotal => Quantity * (DiscountedPricePerShirt == 0 ? PricePerShirt : DiscountedPricePerShirt);

        public decimal Tax => Subtotal * 0.08m;

        public decimal Total => Subtotal + Tax;
    }
}
