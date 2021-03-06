﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird.Screens
{
	class TitleScreen : Screen
	{
        private Rectangle _flappyAlien;
        private Rectangle _startButton;
		private Rectangle _exitButton;
		private Rectangle _creditButton;
        private Rectangle _instructionsButton;
        private Rectangle _muteButton;
        System.Media.SoundPlayer sound = new System.Media.SoundPlayer("Content\\Sounds\\Button.wav");

       
        public TitleScreen()
		{
			Statics.GAME_STATE = Statics.STATE.Loading;
		}

		public override void LoadContent()
		{
            _flappyAlien = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Title\\Title"].X, (int)Statics.MANAGER_UI.TextureVectors["Title\\Title"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Title"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Title"].Height);
            _startButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Title\\Start"].X, (int)Statics.MANAGER_UI.TextureVectors["Title\\Start"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
			_exitButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Title\\Exit"].X, (int)Statics.MANAGER_UI.TextureVectors["Title\\Exit"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
			_creditButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Title\\Credit"].X, (int)Statics.MANAGER_UI.TextureVectors["Title\\Credit"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
            _instructionsButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Title\\Instructions"].X, (int)Statics.MANAGER_UI.TextureVectors["Title\\Instructions"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
            _muteButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Title\\Mute2"].X, (int)Statics.MANAGER_UI.TextureVectors["Title\\Mute2"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);
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
			// Input : Mouse

			if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _startButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
			{
				sound.Play();
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Level"];
			}

			if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _exitButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
			{
				sound.Play();
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Confirm"];
			}
			if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _creditButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
			{
				sound.Play();
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Credit"];
			}

            if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _instructionsButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
                sound.Play();
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Instructions"];
            }

            if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _muteButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
                sound.Stop();

            }

            if (_muteButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))

            {

                _muteButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Title\\Mute2"].X-2, (int)Statics.MANAGER_UI.TextureVectors["Title\\Mute2"].Y-2, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width+4, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height+4);

            }

            if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _flappyAlien.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
                Statics.EasterCount++;
                if (Statics.EasterCount == 4)
                {
                        Statics.EasterCount = 0;
                }
            }

            // Input : Keyboard

            if (Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.Start) || Statics.MANAGER_INPUT.IsKeyPressed(Keys.Enter))
			{
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Level"];
			}

			if (Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.Back) || Statics.MANAGER_INPUT.IsKeyPressed(Keys.Escape))
			{
				Statics.GAME_STATE = Statics.STATE.Exit;
			}
		}
	}
}
