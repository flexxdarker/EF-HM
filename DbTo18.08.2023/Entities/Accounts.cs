using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Entities
{
    public class Accounts
    {
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Login { get; set; }
        [MaxLength(200)]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public virtual Clients Clients { get; set; }
    }
}
