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
                wplayer = new WMPLib.WindowsMediaPlayer();

                wplayer.URL = path;
                wplayer.controls.play();
            }
            else if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                wplayer = new WMPLib.WindowsMediaPlayer();

                wplayer.URL = path;
                wplayer.controls.play();
            }
        }

        public static void StopMusic()
        {
            if(wplayer != null)
            {
                wplayer.controls.stop();
            }
        }
    }
}
