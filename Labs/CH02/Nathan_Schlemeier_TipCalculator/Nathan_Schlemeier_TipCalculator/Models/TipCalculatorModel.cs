using System.ComponentModel.DataAnnotations;

namespace Nathan_Schlemeier_TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "The meal cost is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The meal cost must be greater than 0.")]
        public decimal MealCost { get; set; }

        public decimal TipAmount { get; private set; }

        public TipCalculatorModel()
        {
            MealCost = 0.0m;
            TipAmount = 0.0m;
        }

        public void CalculateTip(decimal tipPercentage)
        {
            TipAmount = MealCost * (tipPercentage / 100);
        }
    }
}
