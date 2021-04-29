using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HalfLife.Models.DbModels
{
    public class Substance
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int HalfLifeInMinutes { get; set; }
        public int AbsorptionTimeInMinutes { get; set; }
    }
}
