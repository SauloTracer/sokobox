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
        public Vector2 position, tilePosition;
        Texture2D texture;

        public Button(bool _isRed, Vector2 _position, Texture2D _texture)
        {
            isRed = _isRed;
            position = _position;
            texture = _texture;
        }

        public void Update(TileMap map1)
        {
            foreach (Box box in map1.boxList)
            {
                if (box.position == this.position) { isPressed = true; }
            }

            if (isPressed == true)
            {
                foreach (FakeWall wall in map1.fakeWallList)
                {
                    if ((wall.isRed == this.isRed) && (!wall.isPassable)) { wall.isPassable = true; } 
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }
}
