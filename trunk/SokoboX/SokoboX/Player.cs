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
        static public Vector2 position = new Vector2(160,160);
        static public Vector2 tileCoordinates = Vector2.Zero;
        static public facing playerFacing = facing.DOWN;
        static public Point upLeft, upRight, downLeft, downRight = new Point();
        static public bool upCollision, downCollision, leftCollision, rightCollision, caixa;
        static public Rectangle playerBoundaries;
        public enum facing { UP, DOWN, LEFT, RIGHT };
        static public Box caixaAtual;
        static public double intervalo;

        static public void drawPlayer(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        static public void updatePlayer()
        {
            playerBoundaries = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            upLeft.X = playerBoundaries.Left + 2;
            upLeft.Y = playerBoundaries.Top + 2;

            upRight.X = playerBoundaries.Right - 2;
            upRight.Y = playerBoundaries.Top + 2;

            downLeft.X = playerBoundaries.Left + 2;
            downLeft.Y = playerBoundaries.Bottom - 2;

            downRight.X = playerBoundaries.Right - 2;
            downRight.Y = playerBoundaries.Bottom - 2;

            tileCoordinates.X = (int)(position.X / 32);
            tileCoordinates.Y = (int)(position.Y / 32);

        }

        static public bool colisao(TileMap map)
        {
            Point ponto = new Point();
            bool retorno = false;
            switch(playerFacing)
            {
                case facing.DOWN:
                    ponto = downLeft;
                    ponto.Y += 2;
                    downCollision = (map.getTileId(ponto) == 2);
                    caixa = colisaoCaixa(map, ponto);
                    ponto = downRight;
                    ponto.Y += 2;
                    downCollision = (downCollision || (map.getTileId(ponto) == 2));
                    caixa = (caixa || colisaoCaixa(map, ponto));
                    retorno = downCollision;
                    break;
                case facing.UP:
                    ponto = upLeft;
                    ponto.Y -= 2;
                    upCollision = (map.getTileId(ponto) == 2);
                    caixa = colisaoCaixa(map, ponto);
                    ponto = upRight;
                    ponto.Y -= 2;
                    upCollision = (upCollision || (map.getTileId(ponto) == 2));
                    caixa = (caixa || colisaoCaixa(map, ponto));
                    retorno = upCollision;
                    break;
                case facing.LEFT:
                    ponto = downLeft;
                    ponto.X -= 2;
                    leftCollision = (map.getTileId(ponto) == 2);
                    caixa = colisaoCaixa(map, ponto);
                    ponto = upLeft;
                    ponto.X -= 2;
                    leftCollision = (leftCollision || (map.getTileId(ponto) == 2));
                    caixa = (caixa || colisaoCaixa(map, ponto));
                    retorno = leftCollision;
                    break;
                case facing.RIGHT:
                    ponto = downRight;
                    ponto.X += 2;
                    rightCollision = (map.getTileId(ponto) == 2);
                    caixa = colisaoCaixa(map, ponto);
                    ponto = upRight;
                    ponto.X += 2;
                    rightCollision = (rightCollision || (map.getTileId(ponto) == 2));
                    caixa = (caixa || colisaoCaixa(map, ponto));
                    retorno = rightCollision;
                    break;
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

    }
}
