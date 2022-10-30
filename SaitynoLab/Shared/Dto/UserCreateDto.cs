using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaitynoLab.Shared.Dto
{
    public class UserCreateDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;
    }
}
