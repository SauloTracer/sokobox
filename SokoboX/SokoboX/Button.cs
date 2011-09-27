using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    class Button
    {
        public bool isRed, isPressed;
        public Vector2 position;
        public Texture2D texture;

        public Button(bool _isRed, Vector2 _position)
        {
            isRed = _isRed;
            position = _position;
        }

        public void Update(TileMap map1)
        {
            isPressed = false;
            foreach (Box box in map1.boxList)
            {
                if (box.position == this.position) { isPressed = true; }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }
}
