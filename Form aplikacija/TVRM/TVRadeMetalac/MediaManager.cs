using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVRadeMetalac
{
    public static class MediaManager
    {
        static WMPLib.WindowsMediaPlayer wplayer;

        public static void PlayMusic(string path)
        {
            if(wplayer == null)
            {
                PlayNextSong(GetNextSong(path));
            }
            else if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayNextSong(GetNextSong(path));
            }
        }

        public static void StopMusic()
        {
            if(wplayer != null)
            {
                wplayer.controls.stop();
            }
        }

        public static void NewSong(string path)
        {
            PlayNextSong(GetNextSong(path));
        }

        static void PlayNextSong(string path)
        {
            wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = path;
            wplayer.controls.play();
        }

        static string GetNextSong(string path)
        {
            try
            {
                string[] songs = System.IO.Directory.GetFiles(path, "*.mp3");
                if(songs.Length == 0)
                    throw new Exception("Nisu pronadjeni fajlovi sa ekstenzijom '.mp3' u odabranom folderu."+
                        "Probajte neki drugi folder.");
                return songs[new Random().Next(0, songs.Length)];
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return "";
            }
        }

        public static void ChangeMusicState()
        {
            if (wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                wplayer.controls.pause();
            else
                wplayer.controls.play();
        }
    }
}
