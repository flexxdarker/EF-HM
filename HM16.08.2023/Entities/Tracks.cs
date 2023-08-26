using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM16._08._2023.Entities
{
    public class Tracks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int AlbumsId { get; set; }
        public Albums Albums { get; set; }
    }
}
