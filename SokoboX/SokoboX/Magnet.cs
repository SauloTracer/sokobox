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
            Player.podeMover = false;
            bool liberaPlayer = true;

            foreach (Box box in map1.boxList)
            {
                if (!box.isStone)
                {
                    #region MagnetUpdate
                    switch (facing)
                    {
                        case Facing.RIGHT:

                            if (((box.position.Y / 32) == tilePosition.Y) && ((box.position.X / 32) > tilePosition.X) && (Player.movendo == false))
                            {
                                if (pushing)
                                {
                                    if (box.podeMoverCaixa(map1, 'O'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveRight(map1);
                                    }
                                }
                                else
                                {
                                    if (box.podeMoverCaixa(map1, 'L'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveLeft(map1);
                                    }
                                }
                            }
                            break;

                        case Facing.LEFT:

                            if (((box.position.Y / 32) == tilePosition.Y) && ((box.position.X / 32) < tilePosition.X) && (Player.movendo == false))
                            {
                                if (!pushing)
                                {
                                    if (box.podeMoverCaixa(map1, 'O'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveRight(map1);
                                    }
                                }
                                else
                                {
                                    if (box.podeMoverCaixa(map1, 'L'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveLeft(map1);
                                    }
                                }
                            }

                            break;

                        case Facing.UP:

                            if (((box.position.Y / 32) < tilePosition.Y) && ((box.position.X / 32) == tilePosition.X) && (Player.movendo == false))
                            {
                                if (pushing)
                                {
                                    if (box.podeMoverCaixa(map1, 'N'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveUp(map1);
                                    }
                                }
                                else
                                {
                                    if (box.podeMoverCaixa(map1, 'S'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveDown(map1);
                                    }
                                }
                            }

                            break;

                        case Facing.DOWN:

                            if (((box.position.Y / 32) > tilePosition.Y) && ((box.position.X / 32) == tilePosition.X) && (Player.movendo == false))
                            {
                                if (!pushing)
                                {
                                    if (box.podeMoverCaixa(map1, 'N'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveUp(map1);
                                    }
                                }
                                else
                                {
                                    if (box.podeMoverCaixa(map1, 'S'))
                                    {
                                        Player.podeMover = liberaPlayer = false;
                                        box.moveDown(map1);
                                    }
                                }
                            }

                            break;
                    }
                    #endregion
                }
            }

            Player.podeMover = liberaPlayer;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
