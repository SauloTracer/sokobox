using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Storage;

namespace SokoboX
{
   
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        TileMap map1;
        Menu menu = new Menu();
        Tile tileSet = new Tile();
        int squaresAcross = 20;
        int squaresDown = 15;
        int currentMap = 0;
        int currentInstructions = 0;
        int score = 0;
        TimeSpan tempoInicial, tempoFinal;
        TimeSpan levelTime = new TimeSpan(0, 5, 0);
        SpriteFont font;
        KeyboardState keyboardState, previousState;
        SoundManager sound;
        enum Screens { MENU, GAME, OPTIONS, PAUSE };
        enum World { FOREST, DESERT, ICE, CAVE, INDUSTRY, DUNGEON };
        World currentWorld;
        Screens currentScreen = Screens.MENU;
        Texture2D instructions, barraEsplendida, pauseScreen;
        StorageContainer storageContainer;
        SaveGame saveGame = new SaveGame();
        string saveFile = "savegame.sav";
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 480;
            graphics.PreferredBackBufferWidth = 640;
            graphics.IsFullScreen = false;
            Content.RootDirectory = "Content";
            sound = new SoundManager(this);
        }

        protected override void Initialize()
        {
            currentMap = 0;
            MapArrays.mapListInit();
            map1 = new TileMap(currentMap);
            map1.initializeMap(sound);
            menu.Initialize(this.Content);
            Player.podeMover = true;
            tempoInicial = new TimeSpan(0, 0, 301);
            tempoFinal = tempoInicial;
            base.Initialize();
        }

        protected void carregaTexturaCaixas()
        {
            #region DetermineWorld
            if ((map1.currentMap <= 8) && (currentWorld != World.FOREST))
            {
                currentWorld = World.FOREST;
            }
            if ((map1.currentMap >= 9) && (map1.currentMap <= 17) && (currentWorld != World.INDUSTRY))
            {
                currentWorld = World.INDUSTRY;
            }
            if ((map1.currentMap >= 18) && (map1.currentMap <= 26) && (currentWorld != World.DESERT))
            {
                currentWorld = World.DESERT;
            }
            if ((map1.currentMap >= 27) && (map1.currentMap <= 35) && (currentWorld != World.ICE))
            {
                currentWorld = World.ICE;
            }
            if ((map1.currentMap >= 36) && (map1.currentMap <= 44) && (currentWorld != World.CAVE))
            {
                currentWorld = World.CAVE;
            }
            if ((map1.currentMap >= 45) && (map1.currentMap <= 53) && (currentWorld != World.DUNGEON))
            {
                currentWorld = World.DUNGEON;
            }
            #endregion

            switch (currentWorld)
            {
                case World.FOREST:
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Forest/tileset");
                    break;
                case World.INDUSTRY:
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Industrial/tileset");
                    break;
                case World.DESERT:
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Desert/tileset");
                    break;
                case World.ICE:
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Ice/tileset");
                    break;
                case World.CAVE:
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Cave/tileset");
                    break;
                case World.DUNGEON:
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Dungeon/tileset");
                    break;
            }

            foreach (Box box in map1.boxList)
            {
                switch (currentWorld)
                {
                    case World.FOREST:
                        box.boxTexture = Content.Load<Texture2D>("Graphics/Forest/box");
                        break;
                    case World.INDUSTRY:
                        box.boxTexture = Content.Load<Texture2D>("Graphics/Industrial/box");
                        break;
                    case World.DESERT:
                        box.boxTexture = Content.Load<Texture2D>("Graphics/Desert/box");
                        break;
                    case World.ICE:
                        if (!box.icyBox) box.boxTexture = Content.Load<Texture2D>("Graphics/Ice/box");
                        else { box.boxTexture = Content.Load<Texture2D>("Graphics/Ice/ice_box"); }
                        break;
                    case World.CAVE:
                        if (!box.isStone) box.boxTexture = Content.Load<Texture2D>("Graphics/Cave/box");
                        else { box.boxTexture = Content.Load<Texture2D>("Graphics/Cave/rock"); }
                        break;
                    case World.DUNGEON:
                        if ((!box.isStone) && (!box.icyBox)) box.boxTexture = Content.Load<Texture2D>("Graphics/Dungeon/box");
                        if (box.isStone) box.boxTexture = Content.Load<Texture2D>("Graphics/Cave/rock");
                        if (box.icyBox) box.boxTexture = Content.Load<Texture2D>("Graphics/Ice/ice_box");
                        break;
                }
            }

            #region MagnetsLoad

            foreach (Magnet magnet in map1.magnetList)
            {
                if (magnet.pushing)
                {
                    switch (magnet.facing)
                    {
                        case Magnet.Facing.DOWN:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Push_Down");
                            break;
                        case Magnet.Facing.LEFT:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Push_Left");
                            break;
                        case Magnet.Facing.RIGHT:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Push_Right");
                            break;
                        case Magnet.Facing.UP:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Push_Up");
                            break;
                    }
                }
                else
                {
                    switch (magnet.facing)
                    {
                        case Magnet.Facing.DOWN:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Pull_Down");
                            break;
                        case Magnet.Facing.LEFT:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Pull_Left");
                            break;
                        case Magnet.Facing.RIGHT:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Pull_Right");
                            break;
                        case Magnet.Facing.UP:
                            magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Pull_Up");
                            break;
                    }
                }
            }
            #endregion

            foreach (Button button in map1.buttonList)
            {
                if (button.isRed) button.texture = Content.Load<Texture2D>("Graphics/General/Button_Red");
                else button.texture = Content.Load<Texture2D>("Graphics/General/Button_Blue");
            }

            foreach (FakeWall wall in map1.fakeWallList)
            {
                switch (currentWorld)
                {
                    case World.DESERT:
                        wall.texture = Content.Load<Texture2D>("Graphics/Desert/wall");
                        break;
                    case World.DUNGEON:
                        wall.texture = Content.Load<Texture2D>("Graphics/Dungeon/wall");
                        break;
                }
            }
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            tileSet.texture = Content.Load<Texture2D>("Graphics/Forest/tileset");
            Player.texture = Content.Load<Texture2D>("Graphics/General/player");
            instructions = Content.Load<Texture2D>("Graphics/Instructions/Instrucoes1");
            barraEsplendida = Content.Load<Texture2D>("Graphics/General/Barra_Esplendida");
            pauseScreen = Content.Load<Texture2D>("Graphics/General/Pause_Screen");
            font = Content.Load<SpriteFont>("SpriteFont1");
            carregaTexturaCaixas();
            sound.soundLoad("menu");
            sound.playSong();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
        
            keyboardState = Keyboard.GetState();

            switch (currentScreen)
            {
                case Screens.GAME:
                    {

                        Player.emEspera = false;

                        foreach (Box box in map1.boxList)
                        {
                            if (box.movendo) { Player.emEspera = true; }
                        }

                        #region GeneralFunctions

                if (keyboardState.IsKeyDown(Keys.Escape)) this.Exit();

                if ((keyboardState.IsKeyDown(Keys.P)) && (previousState.IsKeyUp(Keys.P)))
                {
                    currentScreen = Screens.PAUSE;
                }

                if ((keyboardState.IsKeyDown(Keys.M)) && (previousState.IsKeyUp(Keys.M)))
                {
                    if (sound.playing != true)
                    {
                        sound.playing = true;
                    }
                    else
                    { sound.playing = false; }
                    sound.playSong();
                }

                if ((keyboardState.IsKeyDown(Keys.R)) && (previousState.IsKeyUp(Keys.R)))
                {
                    map1 = new TileMap(currentMap);
                    map1.initializeMap(sound);
                    carregaTexturaCaixas();
                }

                if ((keyboardState.IsKeyDown(Keys.LeftShift) && (!Player.emEspera)))
                {
                   if ((Player.position.X % 32 == 0) && (Player.position.Y % 32 == 0)) Player.speed = 4;
                }

                if (keyboardState.IsKeyUp(Keys.LeftShift))
                {
                    if ((Player.position.X % 32 == 0) && (Player.position.Y % 32 == 0)) Player.speed = 2;
                }

                if ((keyboardState.IsKeyDown(Keys.N)) && (previousState.IsKeyUp(Keys.N)) && (currentMap <= MapArrays.limite())) //FUNÇÃO DE DEBUG - TROCA PARA O PRÓXIMO MAPA
                {

                    if (currentMap < MapArrays.limite())
                    {                    
                        currentMap++;
                        tempoFinal = tempoInicial;
                        map1 = new TileMap(currentMap);
                        map1.initializeMap(sound);
                        carregaTexturaCaixas();

                    }
                }

                if ((keyboardState.IsKeyDown(Keys.B)) && (previousState.IsKeyUp(Keys.B)) && (currentMap <= MapArrays.limite())) //FUNÇÃO DE DEBUG - TROCA PARA O MAPA ANTERIOR
                {

                    if (currentMap > 0)
                    {
                        currentMap--;
                        map1 = new TileMap(currentMap);
                        map1.initializeMap(sound);
                        carregaTexturaCaixas();

                    }
                }

                #endregion
                        
                        #region MovementAndBoxes

                if (!Player.caixa)
                {
                    if (Player.movendo)
                    {
                        switch (Player.playerFacing)
                        {
                            case Player.facing.LEFT: Player.moveLeft(map1); break;
                            case Player.facing.RIGHT: Player.moveRight(map1); break;
                            case Player.facing.UP: Player.moveUp(map1); break;
                            case Player.facing.DOWN: Player.moveDown(map1); break;
                        }
                    }
                    else
                    {
                        if (!Player.emEspera)
                        {
                            if (keyboardState.IsKeyDown(Keys.Up)) { Player.moveUp(map1); Player.movendo = true; }
                            else
                                if (keyboardState.IsKeyDown(Keys.Down)) { Player.moveDown(map1); Player.movendo = true; }
                                else
                                    if (keyboardState.IsKeyDown(Keys.Left)) { Player.moveLeft(map1); Player.movendo = true; }
                                    else
                                        if (keyboardState.IsKeyDown(Keys.Right)) { Player.moveRight(map1); Player.movendo = true; }
                        }
                    }
                }
                else
                {
                    char dir;
                    dir = ' ';
                    switch (Player.playerFacing)
                    {
                        case Player.facing.LEFT: dir = 'L'; break;
                        case Player.facing.RIGHT: dir = 'O'; break;
                        case Player.facing.UP: dir = 'N'; break;
                        case Player.facing.DOWN: dir = 'S'; break;
                    }
                    
                    if (Player.caixaAtual.podeMoverCaixa(map1,dir))
                    {
                        
                        if (!Player.caixaAtual.movendo) sound.playSound();
                        switch (Player.playerFacing)
                        {
                            case Player.facing.LEFT:
                                Player.caixaAtual.moveLeft(map1);
                                Player.moveLeft(map1);
                                Player.caixa = Player.caixaAtual.movendo;
                                break;
                            case Player.facing.RIGHT:
                                Player.caixaAtual.moveRight(map1);
                                Player.moveRight(map1);
                                Player.caixa = Player.caixaAtual.movendo;
                                break;
                            case Player.facing.UP:
                                Player.caixaAtual.moveUp(map1);
                                Player.moveUp(map1);
                                Player.caixa = Player.caixaAtual.movendo;
                                break;
                            case Player.facing.DOWN:
                                Player.caixaAtual.moveDown(map1);
                                Player.moveDown(map1);
                                Player.caixa = Player.caixaAtual.movendo;
                                break;
                        }

                        spriteBatch.Begin();
                        Player.caixaAtual.Draw(spriteBatch);
                        spriteBatch.End();
                    }
                    else
                    {
                        Player.caixa = false;
                    }
                }

                #endregion
                        
                        #region ObjectUpdates

                foreach (Magnet magnet in map1.magnetList)
                {
                    Player.podeMover = false;
                    magnet.UpdateMagnet(map1);
                }
                foreach (Button button in map1.buttonList)
                {
                    button.Update(map1);
                }
                foreach (FakeWall wall in map1.fakeWallList)
                {
                    wall.Update(map1);
                }

                #endregion

                        #region TimeUpdate
                tempoFinal -= gameTime.ElapsedGameTime;

                if (tempoFinal.TotalSeconds <= 0) { tempoFinal = TimeSpan.Zero; }
                #endregion
                        
                        break;
                    }
                case Screens.OPTIONS:
                    {

                        #region InstructionsScreen
                        if (currentScreen == Screens.OPTIONS)
                        {
                            if ((keyboardState.IsKeyDown(Keys.Enter)) && (previousState.IsKeyUp(Keys.Enter)))
                            {
                                switch (currentInstructions)
                                {
                                    case 0:
                                        {
                                            currentInstructions = 1;
                                            instructions = Content.Load<Texture2D>("Graphics/Instructions/Instrucoes2");
                                            break;
                                        }
                                    case 1:
                                        {
                                            currentInstructions = 2;
                                            instructions = Content.Load<Texture2D>("Graphics/Instructions/Instrucoes3");
                                            break;
                                        }
                                    case 2:
                                        {
                                            currentInstructions = 0;
                                            instructions = Content.Load<Texture2D>("Graphics/Instructions/Instrucoes1");
                                            menu.Selected = Menu.Selection.NONE;
                                            currentScreen = Screens.MENU;
                                            break;
                                        }
                                }
                            }
                        }
                        #endregion
                        break;
                    }
                case Screens.MENU:
                    {
                        #region menuUpdate
                        if (currentScreen == Screens.MENU)
                        {
                            menu.Update(keyboardState, previousState);
                            switch (menu.Selected)
                            {
                                case Menu.Selection.START:
                                    currentScreen = Screens.GAME;
                                    sound.soundLoad("grass");
                                    sound.playSong();
                                    break;
                                case Menu.Selection.OPTIONS:
                                    currentScreen = Screens.OPTIONS;
                                    break;
                                case Menu.Selection.EXIT:
                                    this.Exit();
                                    break;
                                case Menu.Selection.NONE:
                                    break;
                                case Menu.Selection.CONTINUE:
                                    if (storageContainer.FileExists(saveFile))
                                    {
                                        //saveGame
                                    }
                                    break;
                            }
                        }
                        #endregion
                        break;
                    }
                case Screens.PAUSE:
                    {
                        if ((keyboardState.IsKeyDown(Keys.P)) && (previousState.IsKeyUp(Keys.P))) currentScreen = Screens.GAME;
                        break;
                    }
            }

            previousState = keyboardState;
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
 
            if (currentScreen == Screens.GAME)
            {
                #region DrawGame

                #region DrawTileMap

                Vector2 firstSquare = new Vector2(Camera.position.X / 32, Camera.position.Y / 32);
                int firstX = (int)firstSquare.X;
                int firstY = (int)firstSquare.Y;

                Vector2 squareOffset = new Vector2(Camera.position.X % 32, Camera.position.Y % 32);
                int offsetX = (int)squareOffset.X;
                int offsetY = (int)squareOffset.Y;

                for (int y = 0; y < squaresDown; y++)
                {
                    for (int x = 0; x < squaresAcross; x++)
                    {
                        spriteBatch.Draw(
                        tileSet.texture,
                        new Rectangle((x * 32) - offsetX, (y * 32) - offsetY, 32, 32),
                        tileSet.GetSourceRectangle(map1.Rows[y + firstY].Columns[x + firstX].TileID),
                        Color.White);
                    }
                }

                #endregion

                #region DrawObjects
                foreach (Button button in map1.buttonList)
                {
                    if (button.texture != null) button.Draw(spriteBatch);
                }

                foreach (Box box in map1.boxList)
                {
                    if (box.boxTexture != null) box.Draw(spriteBatch);
                }

                foreach (Magnet magnet in map1.magnetList)
                {
                    if (magnet.texture != null) magnet.Draw(spriteBatch);
                }

                foreach (FakeWall fakeWall in map1.fakeWallList)
                {
                    if (fakeWall.texture != null) fakeWall.Draw(spriteBatch);
                }
                #endregion

                Player.drawPlayer(spriteBatch);

                #region DrawHUD
                spriteBatch.Draw(barraEsplendida, Vector2.Zero, Color.CornflowerBlue);
                spriteBatch.DrawString(font, "LEVEL " + ((int)(currentMap / 9) + 1) + "-" + ((int)(currentMap % 9) + 1), new Vector2(10, 3), Color.Black);
                spriteBatch.DrawString(font, "TEMPO " + (int)tempoFinal.TotalSeconds, new Vector2(270, 3), Color.Black);
                spriteBatch.DrawString(font, "PONTOS: " , new Vector2(470, 3), Color.Black);

                if (score == 0) spriteBatch.DrawString(font, "PONTOS: 000000", new Vector2(470, 3), Color.Black);

               if((score >= 1000) && (score < 9999))
                   spriteBatch.DrawString(font, "00" + score, new Vector2(557, 3), Color.Black);
               if ((score >= 10000)&& (score < 999999))
                   spriteBatch.DrawString(font, "0" + score, new Vector2(557, 3), Color.Black);
                #endregion

                #region VerifyEndGame
               if (Player.caixaAtual != null)
                {
                    if (Player.caixaAtual.verificaFimDeJogo(map1))
                    {
                        delay(2);
                        score += ((int)tempoFinal.TotalSeconds * 10);
                        tempoFinal = tempoInicial;
                        currentMap++;
                        if (currentMap <= MapArrays.limite())
                        {
                            map1 = new TileMap(currentMap);
                            map1.initializeMap(sound);
                            carregaTexturaCaixas();
                        }
                        else 
                        { 
                            currentMap--; 
                        }
                    }

                }
               #endregion

                #endregion
            }

            if (currentScreen == Screens.MENU)
            {
                menu.Draw(spriteBatch, font);
            }

            if (currentScreen == Screens.OPTIONS)
            {
                spriteBatch.Draw(instructions, Vector2.Zero, Color.White);
            }

            if (currentScreen == Screens.PAUSE)
            {
                spriteBatch.Draw(pauseScreen, Vector2.Zero, Color.White);
            }

            spriteBatch.End();



            base.Draw(gameTime);
        }

        public void delay(int segundos)
        {
            int time = Environment.TickCount;
            while(true) if(Environment.TickCount - time >= (segundos * 1000)) break;            
        }

    }
}
