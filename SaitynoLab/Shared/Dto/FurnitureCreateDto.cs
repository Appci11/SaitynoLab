using System.ComponentModel.DataAnnotations;

namespace SaitynoLab.Shared.Dto
{
    public class FurnitureCreateDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public bool ToAssemble { get; set; } = true;
    }
}
