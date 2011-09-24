using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    class Magnet
    {
        public Vector2 position, tilePosition;
        public Texture2D texture;
        public bool pushing;
        public enum Facing {UP, LEFT, RIGHT, DOWN};
        public Facing facing;

        public Magnet(bool _pushing, Facing _facing)
        {
            facing = _facing;
            pushing = _pushing;
        }

        public void UpdateMagnet(TileMap map1)
        {
            switch (facing)
            {
                case Facing.RIGHT:
                    foreach (Box box in map1.boxList)
                    {
                        if (((box.position.Y / 32) == tilePosition.Y) && ((box.position.X / 32) > tilePosition.X))
                        {
                            if (pushing)
                            {
                                if (box.podeMoverCaixa(map1)) box.moveRight(map1);
                            }
                            else
                            {
                                box.moveLeft(map1);
                            }
                        }
                    }
                    break;

                case Facing.LEFT:
                    foreach (Box box in map1.boxList)
                    {
                        if (((box.position.Y / 32) == tilePosition.Y) && ((box.position.X / 32) < tilePosition.X) && (Player.movendo == false))
                        {
                            if (!pushing) box.moveRight(map1);
                            else box.moveLeft(map1);
                        }
                    }
                    break;

                case Facing.UP:
                    foreach (Box box in map1.boxList)
                    {
                        if (((box.position.Y / 32) > tilePosition.Y) && ((box.position.X / 32) == tilePosition.X))
                        {
                            if (pushing) box.moveUp(map1);
                            else box.moveDown(map1);
                        }
                    }
                    break;

                case Facing.DOWN:
                    foreach (Box box in map1.boxList)
                    {
                        if (((box.position.Y / 32) < tilePosition.Y) && ((box.position.X / 32) == tilePosition.X))
                        {
                            if (!pushing) box.moveUp(map1);
                            else box.moveDown(map1);
                        }
                    }
                    break;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
