using System.ComponentModel.DataAnnotations;

namespace SimplePaymentSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the amount.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The amount must be greater than 0.")]
        public decimal Amount { get; set; }
    }
}
