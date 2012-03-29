using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;

#if WINDOWS
using Microsoft.Xna.Framework.Storage;
#endif
namespace SokoboX
{
    #if WINDOWS
    [Serializable]
#endif
    class SaveGame
    {
        StreamWriter stream;
        StreamReader reader;
        //public int currentLevel;
        //public int score;
        //public int currentLevelTime;
        

        public void Save(int score, int currentLevel)
        {
            stream = new StreamWriter("savegame.sav");
            stream.WriteLine(score);
            stream.WriteLine(currentLevel);
            //stream.WriteLine(currentLevelTime);
            stream.Close();
        }

        public void Load(Game1 game)
        {
            if (!File.Exists("savegame.sav")) return;
            reader = new StreamReader("savegame.sav");
            game.score = int.Parse(reader.ReadLine());
            game.currentMap = int.Parse(reader.ReadLine());
            reader.ReadLine();
            reader.Close();
        }
    }
}
