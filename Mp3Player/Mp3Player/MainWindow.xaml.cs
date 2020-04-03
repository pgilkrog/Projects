using Microsoft.Win32;
using Mp3Player.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Mp3Player
{
    public partial class MainWindow : Window
    {
        MusicPlayer mp = new MusicPlayer();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SongContainer sc = new SongContainer();
        Song tempSong = new Song();

        int currentSongIndex = 0;

        bool isPaused, shuffleOn, repeatOn = false;
        bool volumeOn = true;

        public MainWindow()
        {
            InitializeComponent();
            SongsList.ItemsSource = sc.GetAllSongs();
            TreeList.ItemsSource = sc.GetListOfArtists();

            sliderVolume.Maximum = 1;
            sliderVolume.Minimum = 0;
            sliderVolume.Value = 1;

            MusicProgress.Minimum = 0;

            imgPlay.Source = new BitmapImage(new Uri("Images/play.png", UriKind.Relative));
        }

        public void PlaySong(Song song)
        {
            if (shuffleOn == true)
            {
                Random rnd = new Random();
                int month = rnd.Next(SongsList.Items.Count - 1);
                Song nextSong = SongsList.Items[month] as Song;
                mp.OpenMusic(nextSong.SongPath);
                currentSongIndex = month;
            }
            else
            {
                mp.OpenMusic(song.SongPath);
            }

            mp.PlayMusic();

            lblCurrentlyPlatying.Content = song.Name + Environment.NewLine + song.AlbumName + " - " + song.ArtistName;
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (!isPaused && currentSongIndex != SongsList.SelectedIndex)
            {
                currentSongIndex = SongsList.SelectedIndex;
                if (SongsList.SelectedItem != null)
                {
                    tempSong = SongsList.SelectedItem as Song;
                    PlaySong(tempSong);
                }
                    
                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
                timer.Start();

                isPaused = true;
                imgPlay.Source = new BitmapImage(new Uri("Images/pause.png", UriKind.Relative));

                BitmapImage myimage = new BitmapImage();
                myimage.BeginInit();
                myimage.UriSource = new Uri(tempSong.AlbumImage);
                myimage.EndInit();

                AlbumImage.Source = myimage;
            }
            else if (!isPaused && currentSongIndex == SongsList.SelectedIndex)
            {
                isPaused = true;
                imgPlay.Source = new BitmapImage(new Uri("Images/pause.png", UriKind.Relative));
                BtnPause_Click();
            }
            else
            {
                isPaused = false;
                imgPlay.Source = new BitmapImage(new Uri("Images/play.png", UriKind.Relative));
                BtnPause_Click();
            }
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            MusicProgress.Minimum = 0;
            MusicProgress.Maximum = mp.GetSongMaxTime();
            MusicProgress.Value = mp.GetSongCurrentTime();
            lblSongPlayTime.Content = TimeSpan.FromSeconds(mp.GetSongCurrentTime()).ToString(@"mm\:ss");
            lblSongTimer.Content = TimeSpan.FromSeconds(mp.GetSongMaxTime()).ToString(@"mm\:ss");

            if(MusicProgress.Value >= MusicProgress.Maximum && currentSongIndex+1 < SongsList.Items.OfType<object>().Count())
            {
                currentSongIndex += 1;
                NextSong();
            }
            else
            {
                if (repeatOn == true)
                    currentSongIndex = 0;
            }
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            mp.StopMusic();
        }

        private void BtnPause_Click()
        {
            if(mp.GetSongCurrentTime() != 0)
                mp.PauseMusic(mp.GetSongCurrentTime());
            else
                mp.PauseMusic(0);
        }

        private void SliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mp.Volume(sliderVolume.Value);
            if (sliderVolume.Value <= 0)
                ChangeVolume(true);
            else
                ChangeVolume(false);
        }

        private void MusicProgress_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            double mousePosition = e.GetPosition(MusicProgress).X;
            double percent = (mousePosition / 276) * 100;
            double temp = (MusicProgress.Maximum / 100) * percent;
            mp.SetSongTime(temp);
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            currentSongIndex += 1;
            if (SongsList.Items.Count <= currentSongIndex)
                currentSongIndex = 0;

            NextSong();
        }

        private void Backward_Click(object sender, RoutedEventArgs e)
        {
            currentSongIndex -= 1;
            if (currentSongIndex < 0)
                currentSongIndex = SongsList.Items.Count - 1;

            NextSong();
        }

        private void TreeList_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue is Album selectedItem)
            {
                SongsList.ItemsSource = sc.SortedLisit(selectedItem.AlbumName);
            } else {
                Artist selectedItem2 = e.NewValue as Artist;
                SongsList.ItemsSource = sc.SortedLisit(selectedItem2.ArtistName);
            }
        }

        private void BtnRepeat_Click(object sender, RoutedEventArgs e)
        {
            if(repeatOn == false)
            {
                repeatOn = true;
                imgRepeat.Source = new BitmapImage(new Uri("Images/repeat2.png", UriKind.Relative));
            }
            else
            {
                repeatOn = false;
                imgRepeat.Source = new BitmapImage(new Uri("Images/repeat.png", UriKind.Relative));
            }
        }

        private void BtnShuffle_Click(object sender, RoutedEventArgs e)
        {
            if (shuffleOn == false)
            {
                shuffleOn = true;
                imgShuffle.Source = new BitmapImage(new Uri("Images/shuffle2.png", UriKind.Relative));
            }
            else
            {
                shuffleOn = false;
                imgShuffle.Source = new BitmapImage(new Uri("Images/shuffle.png", UriKind.Relative));
            }
        }

        private void BtnVolume_Click(object sender, RoutedEventArgs e)
        {
            ChangeVolume(volumeOn);
        }

        public void ChangeVolume(bool vol)
        {
            if (volumeOn == true && vol == true)
            {
                volumeOn = false;
                mp.Volume(0);
                sliderVolume.Value = 0;
                imgVolume.Source = new BitmapImage(new Uri("Images/volumeOff.png", UriKind.Relative));
            }
            else
            {
                volumeOn = true;
                mp.Volume(sliderVolume.Value);
                imgVolume.Source = new BitmapImage(new Uri("Images/volumeOn.png", UriKind.Relative));
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                if (e.ClickCount == 2)
                {
                    AdjustWindowSize();
                }
                else
                {
                    Application.Current.MainWindow.DragMove();
                }
            }
        }

        private void AdjustWindowSize()
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void NextSong()
        {
            Song nextSong = SongsList.Items[currentSongIndex] as Song;
            PlaySong(nextSong);
        }
    }
}
