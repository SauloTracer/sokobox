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
        public Texture2D texture;
        public Rectangle area;

        public FakeWall(bool _isRed, bool _isPassable, Vector2 _position)
        {
            isRed = _isRed;
            isPassable = _isPassable;
            position = _position;
            tilePosition.X = position.X / 32;
            tilePosition.Y = position.Y / 32;
            area = new Rectangle((int)position.X, (int)position.Y, 32, 32);
        }

        public void Update(TileMap map1)
        {
            isPassable = false;
            if ((isRed) && (BlueButtonIsPressed(map1)))
            {
                isPassable = true;
            }
            if ((!isRed) && (RedButtonIsPressed(map1)))
            {
                isPassable = true;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!isPassable) spriteBatch.Draw(texture, position, Color.White);
        }

        public bool RedButtonIsPressed(TileMap map)
        {
            foreach (Button button in map.buttonList)
            {
                if ((button.isPressed) && (button.isRed)) { return true; }
            }
            return false;
        }

        public bool BlueButtonIsPressed(TileMap map)
        {
            foreach (Button button in map.buttonList)
            {
                if ((button.isPressed) && (!button.isRed)) return true;
            }
            return false;
        }

    }
}
