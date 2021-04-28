using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalfLife.Models.DbModels
{
    public class Substance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HalfLifeInMinutes { get; set; }
        public int AbsorptionTimeInMinutes { get; set; }
    }
}
