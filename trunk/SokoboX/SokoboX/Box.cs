using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    class Box
    {
        public Vector2 position, tileCoordinates, offset = Vector2.Zero;
        public Texture2D boxTexture;

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(boxTexture, position, Color.White);
        }

    }
}
