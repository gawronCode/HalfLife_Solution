using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HalfLife.Models.DbModels
{
    public class AppUserSubstance
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int SubstanceId { get; set; }
        public Substance Substance { get; set; }
        [Required]
        public string AppUserId { get; set; }
    }
}
