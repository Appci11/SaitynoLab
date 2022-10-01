using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaitynoLab.Shared
{
    public class Furniture
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public bool ToAssemble { get; set; } = true;
        [Required]
        public int OrderId { get; set; }
    }
}
