using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird.Screens


{
    class Instructions : Screen
    {
        private Rectangle _backButton;

        public Instructions()
        {
            Statics.GAME_STATE = Statics.STATE.Loading;
        }

        public override void LoadContent()
        {

            _backButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Instructions\\Back"].X, (int)Statics.MANAGER_UI.TextureVectors["Instructions\\Back"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
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
            if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _backButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Title"];
            }

        }




    }





}
