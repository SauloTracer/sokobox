using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    static class Player
    {
        static public Texture2D texture;
        static public Vector2 position;
        static public Vector2 tileCoordinates = Vector2.Zero;
        static public facing playerFacing = facing.DOWN;
        static public bool caixa, movendo, podeMover;
        public enum facing { UP, DOWN, LEFT, RIGHT };
        static public Box caixaAtual;
        public const int speed = 2;

        static public void drawPlayer(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        static public bool colisaoParede(TileMap map)
        {
            if (!podeMover) return true;
            if (((Player.position.X % 32) != 0) || ((Player.position.Y % 32) != 0)) return false;


            Point ponto = new Point();
            bool retorno = false;

            switch(playerFacing)
            {
                case facing.DOWN:
                    ponto.X = (int)position.X;
                    ponto.Y = (int)position.Y + 32;
                    foreach (FakeWall wall in map.fakeWallList)
                    {
                        if ((wall.isPassable == false) && (wall.area.Intersects(new Rectangle(ponto.X, ponto.Y, 1, 1))))
                        {
                            return true;
                        }
                    }
                    return (map.getTileId(ponto) == 2);
                case facing.UP:
                    ponto.X = (int)position.X;
                    ponto.Y = (int)position.Y - 32;
                    foreach (FakeWall wall in map.fakeWallList)
                    {
                        if ((wall.isPassable == false) && (wall.area.Intersects(new Rectangle(ponto.X, ponto.Y, 1, 1))))
                        {
                            return true;
                        }
                    }
                    return (map.getTileId(ponto) == 2);
                case facing.LEFT:
                    ponto.X = (int)position.X - 32;
                    ponto.Y = (int)position.Y;
                    foreach (FakeWall wall in map.fakeWallList)
                    {
                        if ((wall.isPassable == false) && (wall.area.Intersects(new Rectangle(ponto.X, ponto.Y, 1, 1))))
                        {
                            return true;
                        }
                    }
                    return (map.getTileId(ponto) == 2);
                case facing.RIGHT:
                    ponto.X = (int)position.X + 32;
                    ponto.Y = (int)position.Y;
                    foreach (FakeWall wall in map.fakeWallList)
                    {
                        if ((wall.isPassable == false) && (wall.area.Intersects(new Rectangle(ponto.X, ponto.Y, 1, 1))))
                        {
                            return true;
                        }
                    }
                    return (map.getTileId(ponto) == 2);
            }

            return retorno;
        }

        static public bool colisaoCaixa(TileMap map, Point ponto)
        {
            foreach (Box caixa in map.boxList)
            {
                if (caixa.area.Intersects(new Rectangle(ponto.X, ponto.Y, 1, 1)))
                {
                    caixaAtual = caixa;
                    return true;
                } 
            }
            
            return false;
        }

        static public void moveUp(TileMap map)
        {
            playerFacing = facing.UP;
            if (podeMover)
            {
                Point ponto = new Point((int)position.X, (int)position.Y - 2);
                if ((!caixa) && (colisaoCaixa(map, ponto)))
                {
                    caixa = true;
                    movendo = false;
                }
                else
                {
                    if (!colisaoParede(map)) position.Y -= speed;
                }
                finalizaMovimento();
            }
        }

        static public void moveDown(TileMap map)
        {
            playerFacing = facing.DOWN;
            if (podeMover)
            {
                Point ponto = new Point((int)position.X, (int)position.Y + 33);
                if ((!caixa) && (colisaoCaixa(map, ponto)))
                {
                    caixa = true;
                    movendo = false;
                }
                else
                {
                    if (!Player.colisaoParede(map)) position.Y += speed;
                }
                finalizaMovimento();
            }
        }

        static public void moveLeft(TileMap map)
        {
            playerFacing = facing.LEFT;
            if (podeMover)
            {
                Point ponto = new Point((int)position.X - 2, (int)position.Y);
                if ((!caixa) && (colisaoCaixa(map, ponto)))
                {
                    caixa = true;
                    movendo = false;
                }
                else
                {
                    if (!Player.colisaoParede(map)) position.X -= speed;
                }
                finalizaMovimento();
            }
        }

        static public void moveRight(TileMap map)
        {
            playerFacing = facing.RIGHT;
            if (podeMover)
            {
                Point ponto = new Point((int)position.X + 33, (int)position.Y);
                if ((!caixa) && (colisaoCaixa(map, ponto)))
                {
                    caixa = true;
                    movendo = false;
                }
                else
                {
                    if (!colisaoParede(map)) position.X += speed;
                }
                finalizaMovimento();
            }
        }

        static public void finalizaMovimento()
        {
            if (caixa)
            {
                movendo = false;
            }
            else
            {
                movendo = (((position.X % 32) != 0) || ((position.Y % 32) != 0));
            }
        }

    }
}
