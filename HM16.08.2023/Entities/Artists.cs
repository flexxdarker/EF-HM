using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM16._08._2023.Entities
{
    public class Artists
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountriesId { get; set; }
        public Countries Countries { get; set; }
    }
}
