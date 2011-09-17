using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    class TileMap
    {
        public List<MapRow> Rows = new List<MapRow>();
        public List<Box> boxList = new List<Box>();
        public int MapWidth = 20;
        public int MapHeight = 15;
        public int[,] Map = new int[15, 20];

        public TileMap()
        {
            for (int y = 0; y < MapHeight; y++)
            {
                MapRow thisRow = new MapRow();
                for (int x = 0; x < MapWidth; x++)
                {
                    thisRow.Columns.Add(new MapCell(0));
                }
                Rows.Add(thisRow);
            }

            Map = MapArrays.getMap(2);

            for (int row = 0; row < Map.GetLength(0); row++)
            {
                for (int column = 0; column < Map.GetLength(1); column++)
                {
                    Rows[row].Columns[column].TileID = Map[row, column];
                }
            }
            
        }

        public void initializeMap()
        {
            for (int row = 0; row < Rows.Count(); row++)
            {
                for (int column = 0; column < Rows[row].Columns.Count(); column++)
                {
                    if (Rows[row].Columns[column].TileID == 1)
                    {
                        boxList.Add(new Box());
                        boxList.Last().tileCoordinates = new Vector2(column, row);
                        boxList.Last().position.X = boxList.Last().tileCoordinates.X * 32;
                        boxList.Last().position.Y = boxList.Last().tileCoordinates.Y * 32;
                        boxList.Last().area = new Rectangle((int)boxList.Last().position.X, (int)boxList.Last().position.Y, 32, 32);
                        Rows[row].Columns[column].TileID = 3;
                    }
                    else
                    {
                        if (Rows[row].Columns[column].TileID == 5)
                        {
                            Player.position.X = column * 32;
                            Player.position.Y = row * 32;
                            Rows[row].Columns[column].TileID = 3;
                        }
                    }
                }
            }
        }

        public int getTileId(Point posicao)
        {
            int x, y;
            x = (int)posicao.X / 32;
            y = (int)posicao.Y / 32;
            return this.Map[y, x];
        }

        public Box getCaixaAtPonto(Point ponto)
        {
            Rectangle posicaoXY = new Rectangle(ponto.X, ponto.Y, 1, 1);
            foreach (Box caixa in boxList)
            {
                if (caixa.area.Intersects(posicaoXY)) return caixa;
            }
            return null;
        }

    }

    class MapRow
    {
        public List<MapCell> Columns = new List<MapCell>();
    }
}
