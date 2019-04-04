using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3Player.Models
{
    public class Artist
    {
        public string ArtistName { get; set; }
        public List<Album> Albums { get; set; }
    }
}
