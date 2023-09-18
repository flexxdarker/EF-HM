using DbTo18._08._2023.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hm18._08._2023.Entities
{
    public class Airplanes
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int MaxPassengers { get; set; }
        public string Country { get; set; }
        public virtual Flights Flights { get; set; }
    }
}
