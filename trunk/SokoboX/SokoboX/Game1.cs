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
        bool pushingDown, pushingLeft, pushingUp, pushingRight = false;
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
            

            Player.updatePlayer();

            if (keyboardState.IsKeyDown(Keys.Escape)) this.Exit();

            if (!pushingDown && !pushingUp && !pushingLeft && !pushingRight)
            {
                Player.intervalo = 10.0f;
                if (keyboardState.IsKeyDown(Keys.Up))
                {
                    Player.playerFacing = Player.facing.UP;
                    if (!Player.colisao(map1)) Player.position.Y -= 2;
                }
                if (keyboardState.IsKeyDown(Keys.Down))
                {
                    Player.playerFacing = Player.facing.DOWN;
                    if (!Player.colisao(map1)) Player.position.Y += 2;
                }
                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    Player.playerFacing = Player.facing.LEFT;
                    if (!Player.colisao(map1)) Player.position.X -= 2;
                }
                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    Player.playerFacing = Player.facing.RIGHT;
                    if (!Player.colisao(map1)) Player.position.X += 2;
                }
            }

            if (((keyboardState.IsKeyDown(Keys.Space)) || pushingRight || pushingLeft || pushingUp || pushingDown) && (Player.caixa))
            {
                if ((Player.playerFacing == Player.facing.RIGHT) && ((map1.getTileId(new Point(((int)Player.caixaAtual.position.X/32) + 1,(int)Player.caixaAtual.position.Y/32)) == 3) || pushingRight))
                {

                    if (podeMoverCaixa())
                    {
                        pushingRight = true;
                        Player.caixaAtual.position.X += 2;
                        Player.position.X += 2;
                        Player.caixaAtual.area.X += 2;
                        spriteBatch.Begin();
                        Player.caixaAtual.Draw(spriteBatch);
                        spriteBatch.End();
                        if ((Player.caixaAtual.position.X % 32) == 0)
                        {
                            pushingRight = false;
                            Player.caixa = false;

                        }
                    }
                    else
                    {
                        finalizaMovimentoCaixa();
                    }
                 
                }
                if (((Player.playerFacing == Player.facing.DOWN) && (map1.getTileId(new Point(((int)Player.caixaAtual.position.X / 32), (int)(Player.caixaAtual.position.Y/32) + 1))) == 3) || pushingDown)
                {
                    

                    if (podeMoverCaixa())
                    {
                        pushingDown = true;

                        Player.caixaAtual.position.Y += 2;
                        Player.position.Y += 2;
                        Player.caixaAtual.area.Y += 2;

                        spriteBatch.Begin();
                        Player.caixaAtual.Draw(spriteBatch);
                        spriteBatch.End();
                        
                        if ((Player.caixaAtual.position.Y % 32) == 0)
                        {
                            finalizaMovimentoCaixa();
                        }
                    }
                    else
                    {
                        finalizaMovimentoCaixa();
                    }
                }
            }

            base.Update(gameTime);
        }

        protected void finalizaMovimentoCaixa()
        {
            pushingDown = pushingLeft = pushingUp = pushingRight = false;
            Player.caixa = false;
        }

        protected bool podeMoverCaixa()
        {
            Point ponto = new Point();

            switch (Player.playerFacing)
            {
                case Player.facing.DOWN:
                    ponto.Y += 32;
                    break;
                case Player.facing.UP:
                    ponto.Y -= 32;
                    break;
                case Player.facing.LEFT:
                    ponto.X -= 32;
                    break;
                case Player.facing.RIGHT:
                    ponto.X += 32;
                    break;
            }

            ponto.X += (int)Player.caixaAtual.position.X;
            ponto.Y += (int)Player.caixaAtual.position.Y;

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
