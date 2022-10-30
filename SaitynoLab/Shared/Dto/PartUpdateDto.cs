using SaitynoLab.Shared;
using System.ComponentModel.DataAnnotations;

namespace SaitynoLab.Shared.Dto
{
    public class PartUpdateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        [Required]
        public PartColor Color { get; set; } = PartColor.White;
    }
}