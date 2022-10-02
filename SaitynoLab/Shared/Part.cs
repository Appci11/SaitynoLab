using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaitynoLab.Shared
{
    public class Part
    {
        public int Id { get; set; }
        [Required]
        public int FurnitureId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        public PartColor Color { get; set; } = PartColor.White;
    }
}
