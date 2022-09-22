using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaitynoLab.Shared
{
    public class User
    {
        public int Id { get; set; } = default!; // esant duombazei default nuimt
        public string Username { get; set; } = string.Empty;
        //public string Password { get; set; } = string.Empty;

        //Saziningesnis variantas...
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

    }
}
