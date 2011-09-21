﻿using System;
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
        public ContentManager content;

        public void soundLoad(string url)
        {
           soundEffect = content.Load<SoundEffect>("Sounds/"+url);
        }

        public void playSound()
        {
            soundEffect.Play();
        }
    }
}
