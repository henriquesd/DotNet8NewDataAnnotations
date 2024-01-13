using System.ComponentModel.DataAnnotations;

namespace DotNet8NewDataAnnotations.Models
{
    public class Product
    {
        [Length(2, 20)]
        public string Name { get; set; }
        
        [Range(1, 1000, MinimumIsExclusive = true, MaximumIsExclusive = false)]
        public double Price { get; set; }

        [AllowedValues("Computers", "Video Games")]
        public string Category { get; set; }

        [DeniedValues("Printers")]
        public string SubCategory { get; set; }

        [Base64String]
        public string Description { get; set; }
    }
}