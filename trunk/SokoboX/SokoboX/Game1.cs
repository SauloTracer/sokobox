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
        Tile tileSet = new Tile();
        int squaresAcross = 20;
        int squaresDown = 15;
        int currentMap = 0;
        SpriteFont font;
        SoundEffect soundEffect;
        KeyboardState keyboardState, previousState;
        Texture2D pullMag, pushMag;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 480;
            graphics.PreferredBackBufferWidth = 640;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            currentMap = 0;
            MapArrays.mapListInit();
            map1 = new TileMap(currentMap);
            map1.initializeMap();
            
            base.Initialize();
        }

        protected void carregaTexturaCaixas()
        {
            foreach (Box box in map1.boxList)
            {
                box.boxTexture = Content.Load<Texture2D>("Graphics/Forest/box");
            }

            foreach (Magnet magnet in map1.magnetList)
            {
                if (magnet.pushing)
                {
                    magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Push");
                }
                else
                {
                    magnet.texture = Content.Load<Texture2D>("Graphics/General/Magnet_Pull");
                }
            }
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            tileSet.texture = Content.Load<Texture2D>("Graphics/Forest/tileset");
            Player.texture = Content.Load<Texture2D>("player");
            soundEffect = Content.Load<SoundEffect>("Sounds/Forest/grass_drag");
            font = Content.Load<SpriteFont>("SpriteFont1");
            pushMag = Content.Load<Texture2D>("Graphics/General/Magnet_Push");
            pullMag = Content.Load<Texture2D>("Graphics/General/Magnet_Pull");
            carregaTexturaCaixas();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Escape)) this.Exit();

            if ((keyboardState.IsKeyDown(Keys.R)) && (previousState.IsKeyUp(Keys.R))) 
            {
                map1 = new TileMap(currentMap);
                map1.initializeMap();
                carregaTexturaCaixas();
                if (currentMap > 3)  //TESTE
                {
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Industrial/tileset");
                    foreach (Box box in map1.boxList)
                    {
                        box.boxTexture = Content.Load<Texture2D>("Graphics/Industrial/box");
                    }
                    soundEffect = Content.Load<SoundEffect>("Sounds/Industrial/metal_drag");
                }
            }

            if ((keyboardState.IsKeyDown(Keys.N)) && (previousState.IsKeyUp(Keys.N)) && (currentMap < MapArrays.limite())) //FUNÇÃO DE DEBUG - TROCA PARA O PRÓXIMO MAPA
            {
                currentMap++;
                map1 = new TileMap(currentMap);
                map1.initializeMap();
                carregaTexturaCaixas();
                if (currentMap > 3)  //TESTE
                {
                    tileSet.texture = Content.Load<Texture2D>("Graphics/Industrial/tileset");
                    foreach (Box box in map1.boxList)
                    {
                        box.boxTexture = Content.Load<Texture2D>("Graphics/Industrial/box");
                    }

                }
            }



            if (!Player.caixa)
            {
                if (Player.movendo)
                {
                    switch (Player.playerFacing)
                    {
                        case Player.facing.LEFT:  Player.moveLeft(map1);  break;
                        case Player.facing.RIGHT: Player.moveRight(map1); break;
                        case Player.facing.UP:    Player.moveUp(map1);    break;
                        case Player.facing.DOWN:  Player.moveDown(map1);  break;
                    }
                }
                else
                {
                    if (keyboardState.IsKeyDown(Keys.Up))    { Player.moveUp(map1);    Player.movendo = true; } else
                    if (keyboardState.IsKeyDown(Keys.Down))  { Player.moveDown(map1);  Player.movendo = true; } else 
                    if (keyboardState.IsKeyDown(Keys.Left))  { Player.moveLeft(map1);  Player.movendo = true; } else
                    if (keyboardState.IsKeyDown(Keys.Right)) { Player.moveRight(map1); Player.movendo = true; }
                }
            }
            else
            {
                if (podeMoverCaixa())
                {
                    switch (Player.playerFacing)
                    {
                        case Player.facing.LEFT:
                            Player.caixaAtual.moveLeft(map1);
                            Player.moveLeft(map1);
                            break;
                        case Player.facing.RIGHT:
                            Player.caixaAtual.moveRight(map1);
                            Player.moveRight(map1);
                            break;
                        case Player.facing.UP:
                            Player.caixaAtual.moveUp(map1);
                            Player.moveUp(map1);
                            break;
                        case Player.facing.DOWN:
                            Player.caixaAtual.moveDown(map1);
                            Player.moveDown(map1);
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

            foreach (Magnet magnet in map1.magnetList)
            {
                magnet.UpdateMagnet(map1);
            }

            previousState = keyboardState;

            base.Update(gameTime);
        }

        protected bool podeMoverCaixa()
        {
            if (((Player.caixaAtual.position.X % 32) != 0) || ((Player.caixaAtual.position.Y % 32) != 0)) return true;

            Point ponto = new Point();
            ponto = Point.Zero;

            ponto.X += (int)Player.caixaAtual.position.X;
            ponto.Y += (int)Player.caixaAtual.position.Y;

            switch (Player.playerFacing)
            {
                case Player.facing.UP:    ponto.Y -= 32; break;
                case Player.facing.LEFT:  ponto.X -= 32; break;
                case Player.facing.DOWN: ponto.Y += 32; break;
                case Player.facing.RIGHT: ponto.X += 32; break;
            }

            Box caixaSeguinte = map1.getCaixaAtPonto(ponto);

            bool retorno = ((map1.getTileId(ponto) != 2) && (caixaSeguinte == null));
            if (retorno)
            {
                soundEffect.Play();
            }
            return retorno; 
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

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

            foreach (Box box in map1.boxList)
            {
                if (box.boxTexture != null) box.Draw(spriteBatch);
            }

            foreach (Magnet magnet in map1.magnetList)
            {
                if (magnet.texture != null) magnet.Draw(spriteBatch);
            }

            Player.drawPlayer(spriteBatch);

            if (Player.caixaAtual != null)
            {
                if (Player.caixaAtual.verificaFimDeJogo(map1))
                {
                    delay(3);
                    currentMap++;
                    if (currentMap < MapArrays.limite())
                    {
                        map1 = new TileMap(currentMap);
                        map1.initializeMap();
                        carregaTexturaCaixas();
                        if (currentMap > 3)  //TESTE
                        {
                            tileSet.texture = Content.Load<Texture2D>("Graphics/Industrial/tileset");
                            foreach (Box box in map1.boxList)
                            {
                                box.boxTexture = Content.Load<Texture2D>("Graphics/Industrial/box");
                            }

                        }
                    }
                }

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
