﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird.Screens
{
    class LevelScreen : Screen
    {
		System.Media.SoundPlayer sound = new System.Media.SoundPlayer("Content\\Sounds\\Button.wav");
        private Rectangle _pipeButton;
        private Rectangle _bulletButton;
        private Rectangle _paratroopaButton;
		private Rectangle _backButton;

        public LevelScreen()
        {
            
        }

        public override void LoadContent()
        {
            _pipeButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Level\\Pipe"].X, (int)Statics.MANAGER_UI.TextureVectors["Level\\Pipe"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonPipe"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonPipe"].Height);
            _bulletButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Level\\Bullet"].X, (int)Statics.MANAGER_UI.TextureVectors["Level\\Bullet"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonBullet"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonBullet"].Height);
            _paratroopaButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Level\\Paratroopa"].X, (int)Statics.MANAGER_UI.TextureVectors["Level\\Paratroopa"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonParatroopa"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonParatroopa"].Height);
			_backButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Level\\Back"].X, (int)Statics.MANAGER_UI.TextureVectors["Level\\Back"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);

            base.LoadContent();
        }

        public override void Update()
        {
            // Input : Mouse

            if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _pipeButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
				sound.Play();
                Statics.GAME_WORLD = Statics.WORLD.Pipes;
                
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Characters"];
                Statics.GAME_STATE = Statics.STATE.Playing;
            }
            else if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _bulletButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
				sound.Play();
                Statics.GAME_WORLD = Statics.WORLD.Bullets;

                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Characters"];
                Statics.GAME_STATE = Statics.STATE.Playing;
            }
            else if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _paratroopaButton.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
            {
				sound.Play();
                Statics.GAME_WORLD = Statics.WORLD.Paratroopas;
                
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Characters"];
                Statics.GAME_STATE = Statics.STATE.Playing;
            }

            if (Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.Back) || Statics.MANAGER_INPUT.IsRightMouseClicked() || Statics.MANAGER_INPUT.IsKeyPressed(Keys.Escape))
            {
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Title"];
            }
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
				sound.Play();
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Title"];
			}
		}
    }
}
