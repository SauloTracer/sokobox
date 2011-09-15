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
        static public bool upLeftCollision, upRighCollision, downLeftCollision, downRightCollision;
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
    }
}
