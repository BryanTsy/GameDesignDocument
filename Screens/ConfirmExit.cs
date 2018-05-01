using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
namespace FlappyBird.Screens
{
    class ConfirmExit : Screen
    {
        private Rectangle _yesButton;
        private Rectangle _noButton;

         public ConfirmExit()
        {
            Statics.GAME_STATE = Statics.STATE.Loading;
        }

         public override void LoadContent()
        {
           _yesButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["ConfirmExit\\Yes"].X, (int)Statics.MANAGER_UI.TextureVectors["ConfirmExit\\Yes"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
            _noButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["ConfirmExit\\No"].X, (int)Statics.MANAGER_UI.TextureVectors["ConfirmExit\\No"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
            base.LoadContent();
        }

        public override void Update()
        {
            CheckForInput();
    
            base.Update();
        }

         public override void Draw()
        {
            base.Draw();
        }

       private void CheckForInput()
        {
               if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _yesButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
                Statics.GAME_STATE = Statics.STATE.Exit;
            }
               if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _noButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
                {
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Title"];
            
                }

        }




    }
}
