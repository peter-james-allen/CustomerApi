using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [Range(0,110)]
        public int Age { get; set; }
        [RegularExpression(@"^([A-Za-z]{2}[\d]{1,2}[A-Za-z]?)[\s]+([\d][A-Za-z]{2})$", ErrorMessage = "You must enter a valid postcode (including space)")]
        public string Postcode { get; set; }

        [DisplayName("Height (in meters)")]
        [RegularExpression(@"[0-9]*\.[0-9]{2}$", ErrorMessage = "Height must be a number with 2 decimal places")]
        [Range(0.00, 2.50)]
        public Double HeightInMeters { get; set; }
    }
}
