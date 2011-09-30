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
        public bool movendo, slide, icyBox, isStone;

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
            position.Y -= Player.speed;
            area.Y -= Player.speed;
            finalizaMovimento();
            if ((podeMoverCaixa(map, 'N')) && (icyBox))
            {
                movendo = true;
            }
        }

        public void moveDown(TileMap map)
        {
            position.Y += Player.speed;
            area.Y += Player.speed;
            finalizaMovimento();
            if ((podeMoverCaixa(map, 'S')) && (icyBox))
            {
                movendo = true;
            }
        }

        public void moveLeft(TileMap map)
        {
            position.X -= Player.speed;
            area.X -= Player.speed;
            finalizaMovimento();
            if ((podeMoverCaixa(map, 'L')) && (icyBox))
            {
                movendo = true;
            }
        }

        public void moveRight(TileMap map)
        {
            position.X += Player.speed;
            area.X += Player.speed;
            finalizaMovimento();
            if ((podeMoverCaixa(map, 'O')) && (icyBox))
            {
                movendo = true;
            }
        }

        public void finalizaMovimento()
        {
            movendo = ((((position.X % 32) != 0) || ((position.Y % 32) != 0))||(slide));
        }

        public bool verificaFimDeJogo(TileMap map)
        {
            Point ponto = new Point();
            foreach(Box caixa in map.boxList)
            {
                if (caixa.isStone == false)
                {
                    ponto.X = (int)caixa.position.X;
                    ponto.Y = (int)caixa.position.Y;
                    if ((map.getTileId(ponto) != 4) && (map.getTileId(ponto) != 20)) return false;
                    if ((caixa.position.X % 32 != 0) || (caixa.position.Y % 32 != 0)) return false;
                }

            }
            return true;
        }

        public bool podeMoverCaixa(TileMap map, char dir)
        {
            if (((position.X % 32) != 0) || ((position.Y % 32) != 0)) return true;

            Point ponto = new Point();
            ponto = Point.Zero;

            ponto.X += (int)position.X;
            ponto.Y += (int)position.Y; 

            switch (dir)
            {
                case 'N': ponto.Y -= 32; break;
                case 'L': ponto.X -= 32; break;
                case 'S': ponto.Y += 32; break;
                case 'O': ponto.X += 32; break;
            }

            Box caixaSeguinte = map.getCaixaAtPonto(ponto);

            foreach (FakeWall wall in map.fakeWallList)
            {
                if ((wall.isPassable == false) && (wall.area.Intersects(new Rectangle(ponto.X, ponto.Y, 1, 1))))
                {
                    return false;
                }
            }

            bool retorno = ((map.getTileId(ponto) != 2) && (caixaSeguinte == null));

            return retorno;
        }

    }
}
