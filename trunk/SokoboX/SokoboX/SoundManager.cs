using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SokoboX
{
    class SoundManager
    {
        SoundEffect soundEffect;
        Song themeSong;
        public static bool IsRepeating { get; set; }
        public Boolean playing = true;
        public Game1 game;
        public string tema;

        public SoundManager(Game1 game)
        {
            this.game = game;
        }


        public void soundLoad(string url)
        {
            tema = url;
           soundEffect = game.Content.Load<SoundEffect>("Sounds/Effects/"+url+"_drag");
           themeSong = game.Content.Load<Song>("Sounds/Music/" + url + "_theme");
        }
        public void playSound()
        {
            soundEffect.Play();
        }

        public void playSong()
        {
            if (playing == true)
            {
                MediaPlayer.IsRepeating = true;
              MediaPlayer.Play(themeSong);
                MediaPlayer.IsRepeating = true;
            }
            if (playing == false)
            {
                 MediaPlayer.Pause();
            }
        }
    }
}
