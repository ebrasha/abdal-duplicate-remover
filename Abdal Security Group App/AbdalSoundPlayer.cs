using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App
{
    class AbdalSoundPlayer
    {
        public void sPlayer(string req_sound)
        {


            if (req_sound == "error")
            {
                using (var soundPlayer = new SoundPlayer(@"error.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.Play()
                }
            }


            if (req_sound == "done")
            {
                using (var soundPlayer = new SoundPlayer(@"done.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.Play()
                }
            }


            if (req_sound == "start")
            {
                using (var soundPlayer = new SoundPlayer(@"start.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.Play()
                }
            }

            if (req_sound == "cancel")
            {
                using (var soundPlayer = new SoundPlayer(@"cancel.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.Play()
                }
            }


            if (req_sound == "ab-us")
            {
                using (var soundPlayer = new SoundPlayer(@"ab-us.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.Play()
                }
            }




        }
    }
}