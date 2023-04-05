using System.ComponentModel.DataAnnotations;

namespace full_stack_API.Data
{
    public class MarriottFood
    {
        [Key]
        public int FoodId { get; set; }
        public string? EventName { get; set; }
        public string? Vendor { get; set; }
        public int Rating { get; set; }
    }
}
