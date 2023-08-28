using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Entities
{
    public class Sexs
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Sex { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
    }
}
