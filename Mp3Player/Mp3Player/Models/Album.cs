using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3Player.Models
{
    public class Album
    {
        public string AlbumName { get; set; }
        public int AlbumTracks { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; set; }
    }
}
