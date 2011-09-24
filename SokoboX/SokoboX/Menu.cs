using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace SokoboX
{
    class Menu
    {
        public enum Selection { START, OPTIONS, EXIT, NONE }
        Texture2D background, arrowTexture;
        int menuStartY = 300;
        int arrowSelectionIndex;
        Vector2 arrowPosition;
        public Selection arrowSelection;
        public Selection Selected = Selection.NONE;
        public string[] strings = new string[3];

        public void Initialize(ContentManager content)
        {
            background = content.Load<Texture2D>("Graphics/General/menu_background");
            arrowTexture = content.Load<Texture2D>("Graphics/General/arrow");
            //START
            strings[0] = "INICIAR JOGO";

            //OPTIONS
            strings[1] = "CONFIGURACOES";

            //EXIT
            strings[2] = "SAIR";
        }

        public void Update(KeyboardState keyboardState, KeyboardState previousState)
        {
            switch (arrowSelection)
            {
                case Selection.START:
                    if (keyboardState.IsKeyDown(Keys.Enter) && (previousState.IsKeyUp(Keys.Enter))) { Selected = Selection.START; }
                    break;
                case Selection.OPTIONS:
                    if (keyboardState.IsKeyDown(Keys.Enter) && (previousState.IsKeyUp(Keys.Enter))) { Selected = Selection.OPTIONS; }
                    break;
                case Selection.EXIT:
                    if (keyboardState.IsKeyDown(Keys.Enter) && (previousState.IsKeyUp(Keys.Enter))) { Selected = Selection.EXIT; }
                    break;

            }
            if (keyboardState.IsKeyDown(Keys.Down) && (previousState.IsKeyUp(Keys.Down)))
            {
                if (arrowSelectionIndex != strings.Count() - 1)
                    arrowSelectionIndex++;
                else arrowSelectionIndex = 0;
            }
            if (keyboardState.IsKeyDown(Keys.Up) && (previousState.IsKeyUp(Keys.Up)))
            {
                if (arrowSelectionIndex != 0)
                    arrowSelectionIndex--;
                else arrowSelectionIndex = strings.Count() - 1;
            }
            arrowPosition = new Vector2(360, menuStartY + (32 * arrowSelectionIndex));
            switch (arrowSelectionIndex)
            {
                case 0:
                    arrowSelection = Selection.START;
                    break;
                case 1:
                    arrowSelection = Selection.OPTIONS;
                    break;
                case 2:
                    arrowSelection = Selection.EXIT;
                    break;
            }
        }

        public void Draw(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            for (int i = 0; i < strings.Count(); i++)
            {
                spriteBatch.DrawString(spriteFont, strings[i], new Vector2(400, menuStartY + (i * 32)), Color.White);
            }
            spriteBatch.Draw(arrowTexture, arrowPosition, Color.White);
        }
    }
}

