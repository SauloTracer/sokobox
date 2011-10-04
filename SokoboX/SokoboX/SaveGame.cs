using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Storage;

namespace SokoboX
{
    [Serializable]
    class SaveGame
    {
        public struct SaveGameData
        {
            public int currentLevel;
            public int score;
            public int currentLevelTime;
        }

    }
}
