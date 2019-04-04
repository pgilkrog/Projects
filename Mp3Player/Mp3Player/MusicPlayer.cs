using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows;
using System.IO;

namespace Mp3Player
{
    class MusicPlayer
    {
        MediaPlayer mp = new MediaPlayer();
        bool isPaused = false;

        public void OpenMusic(string file)
        {
             mp.Open(new Uri(file, UriKind.Relative));
        }

        public void PlayMusic()
        {
            mp.Play();
        }

        public void StopMusic()
        {
            mp.Stop();
        }

        public void PauseMusic(double timer)
        {
            if (isPaused)
            {
                mp.Play();
                timer += 1;
                SetSongTime(timer);
                isPaused = false;
            }
            else
            {
                isPaused = true;
                mp.Pause();
            }
        }

        public void Volume(double amount)
        {
            mp.Volume = amount;
        }

        public double GetSongMaxTime()
        {
            return mp.NaturalDuration.HasTimeSpan ? mp.NaturalDuration.TimeSpan.TotalSeconds : 0;
        }

        public double GetSongCurrentTime()
        {
            return mp.NaturalDuration.HasTimeSpan ? mp.Position.TotalSeconds : 0;
        }

        public void SetSongTime(double time)
        {
            TimeSpan timeSpan = new TimeSpan(0,0, Convert.ToInt32(time));
            mp.Position = timeSpan;
        }
    }
}
