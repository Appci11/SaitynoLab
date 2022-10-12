using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaitynoLab.Shared
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        //public string Password { get; set; } = string.Empty;
        //Saziningesnis variantas...
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool isDeleted { get; set; } = false;
        public string Role { get; set; } = "RegisteredUser";

    }
}
