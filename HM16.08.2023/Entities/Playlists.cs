using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM16._08._2023.Entities
{
    public class Playlists
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Tracks> Tracks { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
    }
}
