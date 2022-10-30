using System.ComponentModel.DataAnnotations;

namespace SaitynoLab.Shared.Dto
{
    public class OrderUpdateDto
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public bool IsCompleted { get; set; } = false;
    }
}
