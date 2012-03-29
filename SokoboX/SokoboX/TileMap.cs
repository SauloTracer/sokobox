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
        public List<Magnet> magnetList = new List<Magnet>();
        public List<Button> buttonList = new List<Button>();
        public List<FakeWall> fakeWallList = new List<FakeWall>();
        public int MapWidth = 20;
        public int MapHeight = 15;
        public int[,] Map = new int[15, 20];
        public int currentMap;

        public TileMap(int mapa)
        {

            currentMap = mapa;

            for (int y = 0; y < MapHeight; y++)
            {
                MapRow thisRow = new MapRow();
                for (int x = 0; x < MapWidth; x++)
                {
                    thisRow.Columns.Add(new MapCell(0));
                }
                Rows.Add(thisRow);
            }

            Map = MapArrays.getMap(mapa);

            for (int row = 0; row < Map.GetLength(0); row++)
            {
                for (int column = 0; column < Map.GetLength(1); column++)
                {
                    Rows[row].Columns[column].TileID = Map[row, column];
                }
            }
            
        }

        public void initializeMap(SoundManager sound)
        {

            if (currentMap <= 8)
            {
                if (sound.tema != "grass")
                {
                    sound.soundLoad("grass");
                    sound.playSong();
                }
            }                
            if (currentMap >= 9 && currentMap <= 17)
            {
                if (sound.tema != "metal")
                {
                    sound.soundLoad("metal");
                    sound.playSong();
                }
            }

            if (currentMap >= 18 && currentMap <= 26)
            {
                if (sound.tema != "desert")
                {
                    sound.soundLoad("desert");
                    sound.playSong();
                }
            }
            if (currentMap >= 27 && currentMap <= 35)
            {
                if (sound.tema != "ice")
                {
                    sound.soundLoad("ice");
                    sound.playSong();
                }
            }
            if (currentMap >= 36 && currentMap <= 44)
            {
                if (sound.tema != "cave")
                {
                    sound.soundLoad("cave");
                    sound.playSong();
                }
            }

            if (currentMap >= 45)
            {
                if (sound.tema != "dungeon")
                {
                    sound.soundLoad("dungeon");
                    sound.playSong();
                }
            }
            #region Init_Tiles
            for (int row = 0; row < Rows.Count(); row++)
            {
                for (int column = 0; column < Rows[row].Columns.Count(); column++)
                {
                    if (Rows[row].Columns[column].TileID == 1)
                    {
                        boxList.Add(new Box(false));
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
                    if (Rows[row].Columns[column].TileID == 6)
                    {
                        magnetList.Add(new Magnet(false, Magnet.Facing.RIGHT));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 7)
                    {
                        magnetList.Add(new Magnet(false, Magnet.Facing.UP));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 8)
                    {
                        magnetList.Add(new Magnet(false, Magnet.Facing.LEFT));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 9)
                    {
                        magnetList.Add(new Magnet(false, Magnet.Facing.DOWN));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 10)
                    {
                        magnetList.Add(new Magnet(true, Magnet.Facing.RIGHT));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 11)
                    {
                        magnetList.Add(new Magnet(true, Magnet.Facing.UP));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 12)
                    {
                        magnetList.Add(new Magnet(true, Magnet.Facing.LEFT));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 13)
                    {
                        magnetList.Add(new Magnet(true, Magnet.Facing.DOWN));
                        magnetList.Last().tilePosition = new Vector2(column, row);
                        magnetList.Last().position.X = magnetList.Last().tilePosition.X * 32;
                        magnetList.Last().position.Y = magnetList.Last().tilePosition.Y * 32;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 14)
                    {
                        buttonList.Add(new Button(true, new Vector2(column * 32, row * 32)));
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 15)
                    {
                        fakeWallList.Add(new FakeWall(true, false, new Vector2(column * 32, row * 32)));
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 16)
                    {
                        buttonList.Add(new Button(false, new Vector2(column * 32, row * 32)));
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 17)
                    {
                        fakeWallList.Add(new FakeWall(false, false, new Vector2(column * 32, row * 32)));
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 18)
                    {
                        boxList.Add(new Box(false));
                        boxList.Last().tileCoordinates = new Vector2(column, row);
                        boxList.Last().position.X = boxList.Last().tileCoordinates.X * 32;
                        boxList.Last().position.Y = boxList.Last().tileCoordinates.Y * 32;
                        boxList.Last().area = new Rectangle((int)boxList.Last().position.X, (int)boxList.Last().position.Y, 32, 32);
                        boxList.Last().icyBox = true;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 19)
                    {
                        boxList.Add(new Box(false));
                        boxList.Last().tileCoordinates = new Vector2(column, row);
                        boxList.Last().position.X = boxList.Last().tileCoordinates.X * 32;
                        boxList.Last().position.Y = boxList.Last().tileCoordinates.Y * 32;
                        boxList.Last().area = new Rectangle((int)boxList.Last().position.X, (int)boxList.Last().position.Y, 32, 32);
                        boxList.Last().isStone = true;
                        Rows[row].Columns[column].TileID = 3;
                    }
                    if (Rows[row].Columns[column].TileID == 20)
                    {
                        boxList.Add(new Box(false));
                        boxList.Last().tileCoordinates = new Vector2(column, row);
                        boxList.Last().position.X = boxList.Last().tileCoordinates.X * 32;
                        boxList.Last().position.Y = boxList.Last().tileCoordinates.Y * 32;
                        boxList.Last().area = new Rectangle((int)boxList.Last().position.X, (int)boxList.Last().position.Y, 32, 32);
                        boxList.Last().isStone = true;
                        Rows[row].Columns[column].TileID = 4;
                    }
                }
            }
            #endregion
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
