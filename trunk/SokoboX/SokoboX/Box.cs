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
        public bool movendo, slide;

        public Box(bool slide = false)
        {
            movendo = false;
            this.slide = slide;
        }

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
            movendo = (((position.X % 32) != 0) || ((position.Y % 32) != 0));
        }

        public bool verificaFimDeJogo(TileMap map)
        {
            Point ponto = new Point();
            foreach(Box caixa in map.boxList)
            {
                ponto.X = (int)caixa.position.X;
                ponto.Y = (int)caixa.position.Y;
                if (map.getTileId(ponto) != 4) return false;
            }
            return true;
        }

    }
}
