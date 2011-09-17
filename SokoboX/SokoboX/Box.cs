using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    class Box
    {
        public Vector2 position, tileCoordinates, offset = Vector2.Zero;
        public Texture2D boxTexture;
        public Rectangle area;

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(boxTexture, position, Color.White);
        }

        public void moveUp(TileMap map)
        {
            position.Y -= 2;
            area.Y -= 2;
            finalizaMovimento();
        }

        public void moveDown(TileMap map)
        {
            position.Y += 2;
            area.Y += 2;
            finalizaMovimento();
        }

        public void moveLeft(TileMap map)
        {
            position.X -= 2;
            area.X -= 2;
            finalizaMovimento();
        }

        public void moveRight(TileMap map)
        {
            position.X += 2;
            area.X += 2;
            finalizaMovimento();
        }

        public void finalizaMovimento()
        {
            Player.caixa = (((position.X % 32) != 0) || ((position.Y % 32) != 0));
        }

       /* public bool colisao(TileMap map)
        {
            if (((Player.caixaAtual.position.X % 32) != 0) || ((Player.caixaAtual.position.Y % 32) != 0)) return true;

            Point ponto = new Point();
            ponto = Point.Zero;

            ponto.X += (int)Player.caixaAtual.position.X;
            ponto.Y += (int)Player.caixaAtual.position.Y;

            switch (Player.playerFacing)
            {
                case Player.facing.DOWN: ponto.Y += 32; break;
                case Player.facing.UP: ponto.Y -= 32; break;
                case Player.facing.LEFT: ponto.X -= 32; break;
                case Player.facing.RIGHT: ponto.X += 32; break;
            }

            Box caixaSeguinte = map.getCaixaAtPonto(ponto);

            return ((map.getTileId(ponto) == 2) || (caixaSeguinte != null));
        }*/

    }
}
