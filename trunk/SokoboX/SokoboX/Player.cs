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
        static public Vector2 position = new Vector2(96,128);
        static public Vector2 tileCoordinates = Vector2.Zero;
        static public facing playerFacing = facing.DOWN;
        static public Point upLeft, upRight, downLeft, downRight = new Point();
        static public bool upCollision, downCollision, leftCollision, rightCollision;
        static public Rectangle playerBoundaries;
        public enum facing { UP, DOWN, LEFT, RIGHT };

        static public void drawPlayer(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        static public void updatePlayer()
        {
            playerBoundaries = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            upLeft.X = playerBoundaries.Left;
            upLeft.Y = playerBoundaries.Top;

            upRight.X = playerBoundaries.Right;
            upRight.Y = playerBoundaries.Top;

            downLeft.X = playerBoundaries.Left;
            downLeft.Y = playerBoundaries.Bottom;

            downRight.X = playerBoundaries.Right;
            downRight.Y = playerBoundaries.Bottom;

            tileCoordinates.X = (int)(position.X / 32);
            tileCoordinates.Y = (int)(position.Y / 32);

        }

        static public bool colisao(TileMap map)
        {
            Point ponto = new Point();
            switch(playerFacing)
            {
                case facing.DOWN:
                    ponto = downLeft;
                    ponto.Y += 2;
                    downCollision = (map.getTileId(ponto) == 2);
                    ponto = downRight;
                    ponto.Y += 2;
                    downCollision = (downCollision || (map.getTileId(ponto) == 2));
                    return downCollision;
                case facing.UP:
                    ponto = upLeft;
                    ponto.Y -= 2;
                    upCollision = (map.getTileId(ponto) == 2);
                    ponto = upRight;
                    ponto.Y -= 2;
                    upCollision = (upCollision || (map.getTileId(ponto) == 2));
                    return upCollision;
                case facing.LEFT:
                    ponto = downLeft;
                    ponto.X -= 2;
                    leftCollision = (map.getTileId(ponto) == 2);
                    ponto = upLeft;
                    ponto.X -= 2;
                    leftCollision = (leftCollision || (map.getTileId(ponto) == 2));
                    return leftCollision;
                case facing.RIGHT:
                    ponto = downRight;
                    ponto.X += 2;
                    rightCollision = (map.getTileId(ponto) == 2);
                    ponto = upRight;
                    ponto.X += 2;
                    rightCollision = (rightCollision || (map.getTileId(ponto) == 2));
                    return rightCollision;
            }
            return false;
        }
    }
}
