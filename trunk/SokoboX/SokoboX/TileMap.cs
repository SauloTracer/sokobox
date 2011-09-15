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

            Map = MapArrays.getMap(1);

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
                        Rows[row].Columns[column].TileID = 3;
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

    }

    class MapRow
    {
        public List<MapCell> Columns = new List<MapCell>();
    }
}
