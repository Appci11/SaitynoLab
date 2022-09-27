using System.ComponentModel.DataAnnotations;

namespace SaitynoLab.Server.Dto
{
    public class UserUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
    }
}
