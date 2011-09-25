using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    class FakeWall
    {
        public bool isRed, isPassable;
        public Vector2 position, tilePosition;
        Texture2D texture;

        public FakeWall(bool _isRed, bool _isPassable, Vector2 _position, Texture2D _texture)
        {
            isRed = _isRed;
            isPassable = _isPassable;
            position = _position;
            tilePosition.X = position.X / 32;
            tilePosition.Y = position.Y / 32;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
