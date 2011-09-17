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

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 480;
            graphics.PreferredBackBufferWidth = 640;
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            MapArrays.mapListInit();
            map1 = new TileMap();
            map1.initializeMap();
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            tileSet.texture = Content.Load<Texture2D>("2tiles");
            Player.texture = Content.Load<Texture2D>("player");
            foreach (Box box in map1.boxList)
            {
                box.boxTexture = Content.Load<Texture2D>("box");
            }

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Escape)) this.Exit();

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
                            Player.moveDown(map1);
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
            }

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
                case Player.facing.DOWN:  ponto.Y += 32; break;
                case Player.facing.UP:    ponto.Y -= 32; break;
                case Player.facing.LEFT:  ponto.X -= 32; break;
                case Player.facing.RIGHT: ponto.X += 32; break;
            }

            Box caixaSeguinte = map1.getCaixaAtPonto(ponto);

            return ((map1.getTileId(ponto) != 2) && (caixaSeguinte == null));
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
                box.Draw(spriteBatch);
            }

            Player.drawPlayer(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
