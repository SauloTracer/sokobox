﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoboX
{
    static class MapArrays
    {
        public static List<int[,]> Maplist = new List<int[,]>(64);

        public static void mapListInit()
        {

            Maplist.Add(new int[15, 20] //FLORESTA 0
            {
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 5, 3, 3, 2, 2, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 1, 2, 2, 3, 3, 1, 3, 3, 3, 1, 1, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 4, 4, 2, 3 },
{ 3, 2, 3, 3, 3, 2, 3, 3, 1, 3, 3, 3, 1, 3, 2, 3, 4, 4, 2, 3 },
{ 3, 2, 3, 3, 3, 2, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 4, 4, 2, 3 },
{ 3, 2, 3, 3, 3, 2, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 4, 4, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] { //FLORESTA 1
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 3, 3, 1, 1, 3, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 3, 1, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3 },
{ 3, 3, 2, 3, 3, 5, 3, 3, 4, 4, 4, 3, 3, 1, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 1, 2, 2, 3, 4, 2, 4, 3, 2, 2, 1, 3, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 4, 4, 4, 3, 3, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 1, 1, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] {//FLORESTA 2
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 2, 1, 2, 1, 2, 1, 3, 1, 2, 1, 2, 1, 2, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 2, 1, 2, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 4, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 5, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 4, 4, 4, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});
            Maplist.Add(new int[15, 20] { //FLORESTA 3
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 2, 2, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 4, 4, 2, 2, 3, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 2, 2, 2, 4, 2, 2, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 3, 2, 4, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 5, 3, 2, 3 },
{ 3, 3, 2, 2, 2, 1, 3, 3, 1, 3, 2, 3, 1, 1, 3, 3, 3, 2, 2, 3 },
{ 3, 3, 3, 2, 2, 3, 3, 2, 2, 2, 2, 3, 3, 1, 3, 3, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 1, 3, 3, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20]{ //FLORESTA 4
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 1, 3, 3, 3, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 3, 1, 5, 3, 2, 3, 3, 4, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 4, 3, 3, 2, 3, 1, 2, 3, 3, 4, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 4, 3, 3, 1, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 3, 3, 2, 2, 2, 2, 3, 3, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20]{ //FLORESTA 5
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 5, 3, 3, 3, 3, 3, 3, 4, 2, 4, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 1, 3, 3, 1, 3, 3, 1, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 1, 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 4, 2, 4, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] { //FLORESTA 6
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 2, 3, 2, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 4, 4, 4, 2, 2, 2, 3, 2, 2, 4, 4, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 1, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 1, 3, 3, 2, 3, 3, 3, 3, 1, 2, 1, 3, 2, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 3, 2, 3, 3, 3, 3, 3, 3, 1, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 3, 3, 2, 3, 3, 3, 2, 3, 3, 3, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 3, 5, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});
            Maplist.Add(new int[15, 20] { //FLORESTA 7
{ 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 5, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 1, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 3, 2, 3, 1, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 3, 1, 3, 3, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 2, 2, 3, 1, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 2, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});
            Maplist.Add(new int[15, 20] { //FLORESTA 8 FINAL
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 2, 2, 2, 2, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 3, 3, 1, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 2, 2, 2, 2, 2, 3, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 1, 2, 3, 4, 4, 2, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 3, 3, 4, 2, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 2, 5, 3, 4, 2, 1, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 3, 2, 2, 3, 2, 2, 3, 3, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 1, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 2, 2, 2, 2, 3, 3, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }

            });

            Maplist.Add(new int[15, 20] { //INDUSTRIA 1 (9)
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 3 },
{ 3, 3, 2, 3, 3, 3, 5, 3, 1, 3, 1, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 3, 2, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 1, 3, 2, 2, 2 },
{ 3, 2, 2, 1, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 8, 2 },
{ 3, 2, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2 },
{ 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 2, 3, 2, 3, 3, 3, 3, 4, 4, 2 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 2, 3, 2, 3, 3, 3, 3, 4, 4, 2 },
{ 3, 3, 2, 2, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 4, 2, 2 },
{ 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 11, 2, 3, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 }
});
            Maplist.Add(new int[15, 20] { //INDUSTRIA 2 (10)
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 2, 2, 2 },
{ 3, 2, 3, 3, 5, 3, 3, 2, 4, 4, 2, 3, 3, 3, 3, 3, 3, 2, 12, 2 },
{ 3, 2, 3, 1, 3, 1, 3, 2, 4, 4, 3, 3, 3, 2, 2, 2, 3, 2, 2, 2 },
{ 3, 2, 3, 1, 3, 1, 3, 2, 4, 4, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 4, 4, 3, 3, 3, 3, 2, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 3 },
{ 3, 2, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 2, 3, 2, 3, 2, 2, 2, 2, 3, 2, 3, 3, 3, 1, 3, 2, 3 },
{ 3, 2, 3, 2, 3, 2, 3, 1, 3, 3, 2, 3, 2, 3, 3, 1, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 2, 2, 7, 2, 11, 2, 2, 11, 2, 7, 2, 2, 2, 11, 2, 2, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //INDUSTRIA 3 (11)
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 9, 2, 2, 13, 2, 3, 3, 3,3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 2, 2, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 5, 1, 1, 1, 1, 2, 2, 2, 3, 2, 2, 2, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 3, 3, 1, 3, 3, 4, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 1, 3, 3, 4, 2, 3, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 2, 11, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 7, 11, 2, 2, 3, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //INDUSTRIA 4 (12)
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 4, 2, 2, 2, 2, 3, 3, 3, 3, 2, 8, 2, 3, 3, 3 },
{ 3, 3, 2, 10, 2, 4, 2, 3, 3, 3, 3, 3, 2, 3, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 4, 2, 3, 2, 3, 3, 3, 2, 3, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 3, 2, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 1, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 3, 5, 3, 3, 3, 3, 3, 3, 3, 2, 12, 2, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 3, 2, 3, 2, 2, 2, 2, 2, 3, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 1, 3, 3, 3, 2, 10, 2, 3, 3, 3, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 1, 1, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 11, 2, 11, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] { //INDUSTRIA 5 (13)
{ 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 2, 9, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 6, 2, 4, 4, 4, 3, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 3, 4, 4, 4, 2, 8, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 1, 3, 3, 1, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 3, 1, 3, 3, 3, 3, 1, 3, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 3, 3, 3, 2, 2, 3, 3, 3, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 3, 3, 2, 5, 3, 2, 3, 3, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 3, 3, 1, 3, 3, 1, 3, 3, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //INDUSTRIA 6 (14)
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 2, 2, 2, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 3 },
{ 3, 2, 6, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 1, 3, 1, 3, 1, 3, 2, 3 },
{ 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 2, 2, 3 },
{ 3, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 3, 3, 3, 2, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 2, 3, 3, 1, 5, 3, 3, 3, 1, 3, 2, 3 },
{ 3, 2, 1, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 2, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 4, 4, 4, 2, 2, 8, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 4, 4, 4, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //INDUSTRIA 7 
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 9, 2, 3, 2, 13, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 10, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 3, 2, 3, 3 },
{ 3, 3, 2, 5, 3, 3, 3, 3, 2, 3, 3, 2, 4, 3, 3, 2, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 1, 3, 2, 3, 3, 3, 3, 3, 3, 2, 3, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 1, 1, 1, 2, 3, 2, 3, 3, 3, 3, 2, 3, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 3, 2, 3, 2, 3, 3, 3, 3, 3, 3, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 6, 2, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 1, 3, 3, 2, 2, 2, 3, 3, 3, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //INDUSTRIA 8
{ 3, 3, 2, 9, 13, 2, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 2, 2, 2, 2, 2, 2, 3, 3, 2, 13, 2, 3, 3, 2, 2, 2, 2, 2, 2, 2 },
{ 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 2 },
{ 2, 3, 3, 3, 3, 3, 3, 3, 3, 5, 3, 3, 3, 3, 3, 3, 1, 3, 3, 2 },
{ 2, 3, 1, 3, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 3, 3, 3, 3, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 6, 2, 3, 2, 3, 3, 2, 3, 2, 3, 3, 3, 2 },
{ 3, 3, 3, 3, 3, 3, 2, 6, 2, 3, 2, 3, 3, 2, 3, 3, 3, 2, 3, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 3, 3, 2, 3, 1, 3, 1, 3, 2 },
{ 2, 3, 3, 3, 3, 2, 2, 2, 2, 3, 2, 3, 3, 2, 3, 3, 3, 3, 3, 2 },
{ 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 2, 2, 2, 2, 2, 2, 2 },
{ 2, 3, 1, 3, 2, 3, 2, 2, 2, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 2, 2, 2, 2, 2, 3, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 2, 3, 3, 3 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 4, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //INDUSTRIA 9 
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
{ 2, 2, 2, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 2, 3, 2, 3, 2 },
{ 2, 2, 2, 3, 2, 2, 3, 2, 2, 3, 2, 3, 2, 3, 3, 3, 3, 3, 3, 2 },
{ 2, 2, 2, 3, 2, 2, 3, 2, 2, 3, 2, 3, 3, 3, 2, 3, 2, 3, 3, 2 },
{ 2, 3, 3, 3, 2, 2, 3, 2, 2, 3, 2, 3, 3, 3, 3, 3, 3, 3, 2, 2 },
{ 2, 3, 2, 3, 2, 2, 3, 2, 2, 3, 2, 3, 3, 3, 2, 3, 2, 1, 3, 2 },
{ 2, 3, 3, 1, 3, 3, 3, 2, 2, 3, 2, 2, 3, 3, 2, 3, 1, 3, 3, 2 },
{ 2, 3, 3, 3, 3, 2, 3, 3, 3, 5, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2 },
{ 3, 3, 2, 3, 3, 1, 3, 3, 2, 3, 2, 3, 2, 2, 3, 2, 2, 1, 3, 2 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2 },
{ 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2 },
{ 2, 10, 2, 3, 3, 4, 4, 4, 2, 7, 2, 3, 3, 3, 3, 3, 4, 4, 4, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }
            });

            Maplist.Add(new int[15, 20] { //DESERTO 1
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 5, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 2, 14, 3, 3, 3, 3, 3, 3, 3, 3, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 17, 2, 2, 2, 2, 2, 2, 17, 2, 2, 2, 17, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 2, 1, 2, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 1, 3, 3, 2, 3, 2, 3, 3, 1, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 4, 3, 3, 3, 3, 3, 2, 4, 2, 3, 3, 4, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] { //DESERTO 2
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 3, 1, 17, 3, 3, 4, 3, 3, 17, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 1, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 17, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 2, 17, 2, 3, 3 },
{ 3, 3, 2, 4, 2, 2, 2, 3, 1, 3, 14, 3, 3, 2, 2, 2, 4, 2, 3, 3 },
{ 3, 3, 2, 17, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 2, 17, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 4, 3, 3, 3, 2, 5, 3, 3, 3, 3, 1, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 3, 1, 17, 3, 3, 4, 3, 3, 17, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});


            Maplist.Add(new int[15, 20] { //DESERTO 3
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 17, 3, 4, 3, 14, 3, 17, 3, 3, 3, 2, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 17, 17, 17, 3, 3, 17, 17, 17, 3, 3, 17, 17, 17, 2, 3, 3 },
{ 3, 3, 2, 3, 17, 1, 17, 3, 3, 17, 14, 17, 1, 3, 17, 4, 17, 2, 3, 3 },
{ 3, 3, 2, 3, 17, 17, 17, 3, 3, 17, 17, 17, 3, 3, 17, 17, 17, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 17, 17, 17, 17, 17, 17, 17, 17, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 17, 14, 1, 5, 17, 17, 4, 17, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 17, 17, 17, 17, 17, 17, 17, 17, 3, 3, 3, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] { //DESERTO 4
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 17, 17, 17, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 17, 17, 17, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 17, 17, 17, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 4, 14, 3, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 17, 17, 17, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 3, 2 },
{ 2, 3, 14, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 3, 2 },
{ 2, 5, 1, 17, 3, 1, 17, 3, 1, 17, 3, 1, 17, 3, 1, 17, 1, 3, 3, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 3, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 17, 17, 17, 2 },
{ 2, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 2, 3, 3, 3, 2 },
{ 2, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 17, 3, 3, 3, 2 },
{ 2, 3, 4, 17, 3, 4, 17, 3, 4, 17, 3, 4, 17, 3, 4, 17, 3, 3, 3, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }
});

            Maplist.Add(new int[15, 20] { //DESERTO 5
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 15, 17, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 1, 3, 3, 3, 3, 15, 17, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 14, 4, 3, 3, 3, 15, 17, 3, 3, 3, 4, 14, 3, 5, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 15, 17, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 15, 3, 3, 17, 3, 3, 3, 1, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 15, 3, 3, 3, 3, 17, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 15, 3, 3, 3, 3, 3, 3, 17, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 15, 3, 3, 3, 3, 3, 3, 3, 3, 17, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 15, 3, 3, 3, 3, 16, 4, 3, 3, 3, 3, 17, 3, 3, 2, 3 },
{ 3, 2, 3, 15, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 17, 3, 2, 3 },
{ 3, 2, 15, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 17, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] { //DESERTO 6
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 15, 3, 3, 3, 3, 3, 3, 17, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 16, 4, 3, 15, 3, 3, 3, 3, 3, 3, 17, 3, 4, 16, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 15, 3, 3, 3, 3, 3, 3, 17, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 15, 15, 17, 15, 15, 3, 3, 3, 3, 3, 3, 17, 17, 15, 17, 17, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 1, 3, 1, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 17, 17, 15, 17, 17, 3, 3, 3, 3, 3, 3, 15, 15, 17, 15, 15, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 17, 3, 3, 3, 3, 3, 3, 15, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 14, 1, 3, 17, 3, 3, 3, 3, 3, 3, 15, 3, 14, 4, 3, 2, 3 },
{ 3, 2, 5, 3, 3, 3, 17, 3, 3, 3, 3, 3, 3, 15, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});

            Maplist.Add(new int[15, 20] { //DESERTO 7
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 15, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 1, 14, 15, 16, 14, 17, 3, 3, 16, 15, 3, 14, 4, 2, 3 },
{ 3, 2, 3, 3, 5, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 1, 16, 17, 14, 16, 15, 3, 3, 14, 17, 3, 16, 4, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 17, 3, 3, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
                        });

            Maplist.Add(new int[15, 20] { //DESERTO 8
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 4, 3, 3, 15, 3, 3, 3, 3, 17, 3, 3, 4, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 14, 15, 3, 3, 3, 3, 17, 16, 16, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 17, 17, 17, 17, 17, 17, 15, 17, 17, 17, 17, 17, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 17, 17, 17, 17, 17, 17, 15, 15, 15, 15, 15, 15, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 16, 3, 3, 3, 15, 3, 3, 14, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 15, 3, 3, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 16, 3, 1, 3, 2, 3, 1, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 5, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
});
            Maplist.Add(new int[15, 20] { //DESERTO 9 EMPTY
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            });

            Maplist.Add(new int[15, 20] { //ICE 1
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 5, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 18, 3, 3, 3, 3, 18, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 18, 3, 3, 3, 3, 3, 1, 3, 3, 18, 18, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 18, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 4, 4, 4, 4, 2, 3, 3 },
{ 3, 3, 2, 3, 18, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 4, 4, 4, 4, 2, 3, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //ICE 2
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 3, 18, 3, 18, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 3, 18, 5, 18, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 3, 1, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 3, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 4, 3, 3, 3, 4, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 4, 3, 3, 3, 4, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 3, 3, 4, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //ICE 3
{ 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 4, 4, 3, 3, 4, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 2, 4, 4, 3, 3, 4, 2, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 2, 2, 3, 2, 2, 2, 3, 3, 2, 2, 3, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 18, 2, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 3, 3, 3, 5, 3, 3, 2, 18, 3, 3, 2, 2, 3, 3 },
{ 3, 3, 2, 3, 3, 3, 3, 18, 2, 3, 18, 3, 3, 3, 3, 2, 2, 2, 3, 3 },
{ 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3 },
{ 3, 3, 3, 2, 3, 3, 18, 3, 2, 3, 3, 18, 2, 2, 2, 2, 2, 3, 3, 3 },
{ 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3, 3, 2, 2, 2, 2, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 2, 2, 3, 3, 3, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] { //ICE 4
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 18, 3, 18, 3, 2, 3 },
{ 3, 2, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 18, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 5, 3, 2, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 18, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 3 },
{ 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 3, 3, 3, 3, 2, 3, 2, 3 },
{ 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 },
{ 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }
            });

            Maplist.Add(new int[15, 20] {
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 },
{ 3, 2, 2, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 2, 2, 3 },
{ 2, 2, 2, 3, 2, 2, 3, 2, 2, 3, 2, 2, 2, 3, 2, 2, 3, 2, 2, 2 },
{ 2, 2, 2, 3, 3, 3, 3, 2, 2, 3, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2 },
{ 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
{ 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2 },
{ 2, 2, 2, 3, 18, 3, 1, 3, 3, 2, 3, 3, 3, 18, 3, 18, 3, 2, 2, 2 },
{ 2, 2, 2, 3, 3, 3, 3, 3, 3, 5, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2 },
{ 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
{ 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 2, 2, 2 },
{ 2, 2, 2, 3, 3, 3, 3, 2, 2, 3, 2, 2, 2, 3, 3, 3, 3, 2, 2, 2 },
{ 2, 2, 2, 3, 2, 2, 3, 2, 2, 3, 2, 2, 2, 3, 2, 2, 3, 2, 2, 2 },
{ 3, 2, 2, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 2, 2, 3 },
{ 3, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3 }
            });
        }

        public static int[,] getMap(int i)
        {
            return Maplist[i];
        }

        public static int limite()
        {
            return Maplist.Count-1;
        }

    }
}
