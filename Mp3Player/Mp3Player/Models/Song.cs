using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3Player.Models
{
    public class Song
    {
        public string Name { get; set; }
        public string SongPath { get; set; }
        public TimeSpan Duration { get; set; }
        public int Track { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public string[] Performers { get; set; }
        public string Lyrics { get; set; }
        public string AlbumName { get; set; }
        public string AlbumImage { get; set; }
    }
}
