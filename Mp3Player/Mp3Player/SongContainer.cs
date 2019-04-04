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

        int i = 0;

        public List<FileInfo> GetList()
        {
            if(i == 0)
                artists.Add(new Artist { ArtistName = "All" });

            i++;
            return DirSearch(location);
        }

        public List<Song> GetAllSongs()
        {
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
                    .Where(s => s.EndsWith(".wma") || s.EndsWith(".mp3") || s.EndsWith(".wav") || 
                    s.EndsWith(".AIFF") || s.EndsWith(".AAC") || s.EndsWith(".OGG")))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    files.Add(fileInfo);
                    string tempImage = "";
                    
                    var tfile = TagLib.File.Create(file);

                    foreach (string tempFile in Directory.GetFiles(sDir, "Folder.JPG"))
                    {
                        FileInfo imageInfo = new FileInfo(tempFile);

                        if (imageInfo.Exists)
                        {

                        }

                        if (imageInfo != null || imageInfo.FullName != "")
                            tempImage = imageInfo.FullName;

                        tempImage = tempImage.Replace(@"\","/");
                    }

                    var pic = tfile.Tag.Pictures.FirstOrDefault();
                    //string title = tfile.Tag.Title;
                    //string album = tfile.Tag.Album;
                    //uint albumTracks = tfile.Tag.TrackCount;
                    //string[] genre = tfile.Tag.Genres;
                    //string pathName = tfile.Name;
                    //uint trackNumber = tfile.Tag.Track;
                    //TimeSpan duration = tfile.Properties.Duration;
                    //uint year = tfile.Tag.Year;
                    //string[] Performers = tfile.Tag.Performers;
                    //string lyrics = tfile.Tag.Lyrics;
                    //string[] composers = tfile.Tag.Composers;

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
                        AlbumImage = tempImage
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
                            //tempArt.ArtistName = tfile.Tag.FirstAlbumArtist.ToString();
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
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            Songs = Songs.Distinct().ToList();

            return files;
        }

        public List<Artist> GetListOfArtists()
        {
            return artists;
        }

        public List<Song> SortedLisit(string sort)
        {
            if (sort.Equals("All"))
                return GetAllSongs();

            List<Song> newList = new List<Song>();

            foreach(Song f in GetAllSongs())
            {
                if (f.AlbumName.Equals(sort) || f.ArtistName.Equals(sort))
                {
                    newList.Add(f);
                }
            }

            newList = newList.Distinct().ToList();
            return newList;
        }
    }
}
