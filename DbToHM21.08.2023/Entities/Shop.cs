using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbToHM21._08._2023.Entities
{
    public class Shop
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required]
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int? ParkingArea { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
