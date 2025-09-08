using System.ComponentModel.DataAnnotations;

namespace Nathan_Schlemeier_PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        // The subtotal of the price is required and must be greater than 0
        [Required(ErrorMessage = "Subtotal is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Subtotal must be greater than 0.")]
        public decimal? Subtotal { get; set; }

        // The discount percentage of the price is required and must be between 0 and 100
        [Required(ErrorMessage = "Discount percent is required.")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100.")]
        public decimal? DiscountPercent { get; set; }

        // The calculated amount based on subtotal and discount
        public decimal DiscountAmount { get; set; }

        // The total amount after applying the discount to the subtotal
        public decimal Total { get; set; }

        // Calculates the discount amount and total
        public void CalculatePriceQuotation()
        {
            // Make sure both Subtotal and DiscountPercent have values
            if (Subtotal.HasValue && DiscountPercent.HasValue)
            {
                // Access the values of Subtotal and DiscountPercent using .Value
                // Calculate discount amount as (Subtotal * DiscountPercent) / 100
                DiscountAmount = (Subtotal.Value * DiscountPercent.Value) / 100;

                //Calculate the total as Subtotal - DiscountAmount
                Total = Subtotal.Value - DiscountAmount;
            }
        }
    }
}
