using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM18._08._2023.Entities
{
    public class Airplanes
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int MaxPassengers { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
