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
            //// Create Sample Map Data
            //Rows[0].Columns[3].TileID = 22;
            //Rows[0].Columns[4].TileID = 22;
            //Rows[0].Columns[5].TileID = 22;
            //Rows[0].Columns[6].TileID = 22;
            //Rows[0].Columns[7].TileID = 1;

            //Rows[1].Columns[3].TileID = 3;
            //Rows[1].Columns[4].TileID = 1;
            //Rows[1].Columns[5].TileID = 1;
            //Rows[1].Columns[6].TileID = 1;
            //Rows[1].Columns[7].TileID = 1;

            //Rows[2].Columns[2].TileID = 3;
            //Rows[2].Columns[3].TileID = 1;
            //Rows[2].Columns[4].TileID = 1;
            //Rows[2].Columns[5].TileID = 1;
            //Rows[2].Columns[6].TileID = 1;
            //Rows[2].Columns[7].TileID = 1;

            //Rows[3].Columns[2].TileID = 3;
            //Rows[3].Columns[3].TileID = 1;
            //Rows[3].Columns[4].TileID = 1;
            //Rows[3].Columns[5].TileID = 2;
            //Rows[3].Columns[6].TileID = 2;
            //Rows[3].Columns[7].TileID = 2;

            //Rows[4].Columns[0].TileID = 3;
            //Rows[4].Columns[3].TileID = 1;
            //Rows[4].Columns[4].TileID = 1;
            //Rows[4].Columns[5].TileID = 2;
            //Rows[4].Columns[6].TileID = 2;
            //Rows[4].Columns[7].TileID = 2;

            //Rows[5].Columns[2].TileID = 3;
            //Rows[5].Columns[3].TileID = 1;
            //Rows[5].Columns[4].TileID = 1;
            //Rows[5].Columns[5].TileID = 2;
            //Rows[5].Columns[6].TileID = 2;
            //Rows[5].Columns[7].TileID = 2;

            //// End Create Sample Map Data
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
    }

    class MapRow
    {
        public List<MapCell> Columns = new List<MapCell>();
    }
}
