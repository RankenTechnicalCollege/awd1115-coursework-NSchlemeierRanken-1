using System.ComponentModel.DataAnnotations;

namespace HOT1.Models
{
    public class DistanceConverter
    {
        // Constant for inches per centimeter
        public const double CM_PER_IN = 2.54;

        // Property for distance in inches and validation
        [Required(ErrorMessage = "Please enter a distance between 1 and 500 inches.")]
        [Range(1, 500, ErrorMessage = "Distance must be between 1 and 500 inches.")]
        public double DistanceInInches { get; set; }

        // Property for distance in centimeters
        public double DistanceInCentimeters { get; set; }
    }
}
