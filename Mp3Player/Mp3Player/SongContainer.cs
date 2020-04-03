using Mp3Player.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using TagLib;

namespace Mp3Player
{
    class SongContainer
    {
        readonly string location = "C:/Users/" + Environment.UserName + "/Music/";
        List<Artist> artists = new List<Artist>();
        List<Song> Songs = new List<Song>();
        List<Song> filteredSongs = new List<Song>();

        public List<FileInfo> GetList()
        {
            artists.Add(new Artist { ArtistName = "All" });
           
            return DirSearch(location);
        }

        public List<Song> GetAllSongs()
        {
            if(Songs.Count <= 0)
                GetList();

            return Songs;
        }

        public List<FileInfo> DirSearch(string sDir)
        {
            List<FileInfo> files = new List<FileInfo>();
            Artist tempArt = new Artist();
            tempArt.Albums = new List<Album>();

            Album tempAlbums = new Album();
            tempAlbums.Songs = new List<Song>();

            Song tempSong = new Song();
            bool exists = false;

            try
            {
                foreach (string file in Directory.GetFiles(sDir, "*.*")
                    .Where(s => s.EndsWith(".wma") 
                    || s.EndsWith(".mp3") 
                    || s.EndsWith(".wav") 
                    || s.EndsWith(".AIFF") 
                    || s.EndsWith(".AAC") 
                    || s.EndsWith(".OGG")))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    files.Add(fileInfo);
                    string tempImage = "";
                    
                    var tfile = TagLib.File.Create(file);

                    foreach (string tempfile in Directory.GetFiles(sDir, "folder.jpg"))
                    {
                        FileInfo imageinfo = new FileInfo(tempfile);

                        if (imageinfo.Exists)
                           tempImage = imageinfo.FullName.Replace(@"\", "/");
                    }

                    // POSSIBLE SONG VARIABLES //
                    //var pic = tfile.tag.pictures.firstordefault();
                    //string title = tfile.tag.title;
                    //string album = tfile.tag.album;
                    //uint albumtracks = tfile.tag.trackcount;
                    //string[] genre = tfile.tag.genres;
                    //string pathname = tfile.name;
                    //uint tracknumber = tfile.tag.track;
                    //timespan duration = tfile.properties.duration;
                    //uint year = tfile.tag.year;
                    //string[] performers = tfile.tag.performers;
                    //string lyrics = tfile.tag.lyrics;
                    //string[] composers = tfile.tag.composers;

                    Songs.Add(new Song
                    {
                        Name = tfile.Tag.Title,
                        Track = Convert.ToInt32(tfile.Tag.Track),
                        SongPath = tfile.Name,
                        AlbumName = tfile.Tag.Album,
                        ArtistName = tfile.Tag.FirstAlbumArtist,
                        Performers = tfile.Tag.Performers,
                        Genre = tfile.Tag.FirstGenre,
                        Duration = tfile.Properties.Duration,
                        AlbumImage = tempImage,
                        Year = Convert.ToInt32(tfile.Tag.Year)
                    });

                    if (tempArt.ArtistName != fileInfo.Directory.Parent.Name)
                    {
                        foreach(Artist check in artists)
                        {
                            if(check.ArtistName == fileInfo.Directory.Parent.Name)
                                exists = true;
                        }

                        if (!exists || artists.Count == 0)
                        {
                            tempArt.ArtistName = fileInfo.Directory.Parent.Name.ToString();
                            artists.Add(tempArt);
                            string tempLocation = location + tempArt.ArtistName + "/";
                            foreach (string s in Directory.GetDirectories(tempLocation))
                            {
                                tempArt.Albums.Add(new Album { AlbumName = s.Remove(0, tempLocation.Length) });
                            }
                            tempArt.Albums = tempArt.Albums.Distinct().ToList();
                        }
                    }
                }

                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(DirSearch(d));
                }
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            return files;
        }

        public List<Artist> GetListOfArtists()
        {
            return artists;
        }

        public List<Song> SortedLisit(string sort)
        {
            filteredSongs.Clear();

            if (sort.Equals("All"))
                return GetAllSongs();
            
            foreach(Song f in GetAllSongs())
            {
                if (f.AlbumName.Equals(sort) || f.ArtistName.Equals(sort))
                    filteredSongs.Add(f);
            }

            return filteredSongs.Distinct().ToList();
        }
    }
}
