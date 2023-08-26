using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM16._08._2023.Entities
{
    public class Albums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistsId { get; set; }
        public Artists Artists { get; set; }
        public int Year { get; set; }
        public int GanreId { get; set; }
        public Ganres Ganre { get; set;}
    }
}
