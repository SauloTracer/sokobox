using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SokoboX
{
    class MapCell
    {
        public int TileID { get; set; }

        public MapCell(int tileID)
        {
            tileID = TileID;
        }

    }
}
