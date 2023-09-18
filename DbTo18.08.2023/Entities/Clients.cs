using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTo18._08._2023.Entities
{
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int SexsId { get; set; }
        public Sexs Sexs { get; set; }
        public int AccountsId { get; set; }
        public virtual Accounts Accounts { get; set; }
        public int FlightsId { get; set; }
        public virtual Flights Flights { get; set; }
    }
}
