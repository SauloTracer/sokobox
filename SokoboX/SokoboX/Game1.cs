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
        SpriteFont font;
        KeyboardState keyboardState, previousState;
        SoundManager sound;
        enum Screens { MENU, GAME, OPTIONS };
        enum World { FOREST, DESERT, ICE, CAVE, INDUSTRY, DUNGEON };
        World currentWorld;
        Screens currentScreen = Screens.MENU;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 480;
            graphics.PreferredBackBufferWidth = 640;
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
                        break;
                }
            }
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            tileSet.texture = Content.Load<Texture2D>("Graphics/Forest/tileset");
            Player.texture = Content.Load<Texture2D>("player");
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

            if (currentScreen == Screens.GAME)
            {

                #region GeneralFunctions

                if (keyboardState.IsKeyDown(Keys.Escape)) this.Exit();

                if ((keyboardState.IsKeyDown(Keys.M)) && (previousState.IsKeyDown(Keys.M)))
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

                if ((keyboardState.IsKeyDown(Keys.N)) && (previousState.IsKeyUp(Keys.N)) && (currentMap <= MapArrays.limite())) //FUNÇÃO DE DEBUG - TROCA PARA O PRÓXIMO MAPA
                {

                    if (currentMap < MapArrays.limite())
                    {                    
                        currentMap++;
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
                        if (keyboardState.IsKeyDown(Keys.Up)) { Player.moveUp(map1); Player.movendo = true; }
                        else
                            if (keyboardState.IsKeyDown(Keys.Down)) { Player.moveDown(map1); Player.movendo = true; }
                            else
                                if (keyboardState.IsKeyDown(Keys.Left)) { Player.moveLeft(map1); Player.movendo = true; }
                                else
                                    if (keyboardState.IsKeyDown(Keys.Right)) { Player.moveRight(map1); Player.movendo = true; }
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

            }

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

                Player.drawPlayer(spriteBatch);

                if (Player.caixaAtual != null)
                {
                    if (Player.caixaAtual.verificaFimDeJogo(map1))
                    {
                        delay(3);
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
            }

            if (currentScreen == Screens.MENU)
            {
                menu.Draw(spriteBatch, font);
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
