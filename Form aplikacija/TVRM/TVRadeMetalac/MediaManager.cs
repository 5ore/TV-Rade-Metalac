using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVRadeMetalac
{
    /// <summary>
    /// Used for manipulating media such as video and sound.
    /// </summary>
    public static class MediaManager
    {
        /// <summary>
        /// The mp3 player.
        /// </summary>
        static WMPLib.WindowsMediaPlayer wplayer;

        /// <summary>
        /// Plays a random mp3 file from the given path.
        /// </summary>
        /// <param name="path">Seriously? The name is pretty self explanatory.</param>
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

        /// <summary>
        /// I'll let you guess this one.
        /// </summary>
        public static void StopMusic()
        {
            if(wplayer != null)
            {
                wplayer.controls.stop();
            }
        }

        /// <summary>
        /// Checks if the player has not played anything yet or is currently playing a song.
        /// In any case a new song is then played using the 'PlayNextSong(string path)' method.
        /// </summary>
        /// <param name="path">We've already been over this...</param>
        public static void NewSong(string path)
        {
            if (wplayer == null)
            {
                PlayNextSong(GetNextSong(path));
            }

            else if (wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wplayer.controls.stop();
                PlayNextSong(GetNextSong(path));
            }
        }

        /// <summary>
        /// Plays the next random song from the given path.
        /// </summary>
        /// <param name="path">The given path to the folder from which the next random song will be played.
        /// THERE! HAPPY?!! </param>
        static void PlayNextSong(string path)
        {
            wplayer = new WMPLib.WindowsMediaPlayer
            {
                URL = path
            };
            wplayer.controls.play();
        }

        /// <summary>
        /// Gets the next random mp3 file from a folder.
        /// </summary>
        /// <param name="path">Just look at the 'PlayNextSong' method description for it.</param>
        /// <returns>The full path to the newly selected mp3 file.</returns>
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

        /// <summary>
        /// Pauses or resumes the current song depending on its current state.
        /// </summary>
        public static void ChangeMusicState()
        {
            if (wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                wplayer.controls.pause();
            else
                wplayer.controls.play();
        }
    }
}
