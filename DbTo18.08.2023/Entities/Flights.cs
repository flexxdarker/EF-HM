using Hm18._08._2023.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Entities
{
    public class Flights
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public int Number { get; set; }
        public int AirplanesId { get; set; }
        public virtual Airplanes Airplanes { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [NotMapped]
        public DateOnly DispatchDate { get; set; }
        [DataType(DataType.Date)]
        [Required]
        [NotMapped]
        public DateOnly ArrivalDate { get; set; }
        [MaxLength(200)]
        [Required]
        public string DispatchPlace { get; set; }
        [MaxLength(200)]
        [Required]
        public string ArrivalPlace { get; set; }
    }
}
