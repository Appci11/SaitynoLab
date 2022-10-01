using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaitynoLab.Shared
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int BuyerId { get; set; }
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; } = false;
    }
}
