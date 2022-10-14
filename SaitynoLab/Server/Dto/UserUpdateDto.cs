using System.ComponentModel.DataAnnotations;

namespace SaitynoLab.Server.Dto
{
    public class UserUpdateDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Role { get; set; } = string.Empty;
    }
}
