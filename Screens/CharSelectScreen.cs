using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using FlappyBird.Entities;

namespace FlappyBird.Screens
{
	class CharSelectScreen : Screen
	{
		System.Media.SoundPlayer sound = new System.Media.SoundPlayer("Content\\Sounds\\Button.wav");
		private Rectangle _charBirdOri;
		private Rectangle _charBirdOrange;
		private Rectangle _backButton;

		public CharSelectScreen()
		{

		}

		public override void LoadContent()
		{
			_charBirdOri = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOri"].X, (int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOri"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"].Height);
			_charBirdOrange = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOrange"].X, (int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOrange"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOrange"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOrange"].Height);
			_backButton = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Characters\\Back"].X, (int)Statics.MANAGER_UI.TextureVectors["Characters\\Back"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height);

			base.LoadContent();
		}

		public override void Update()
		{
			// Input : Mouse

			if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _charBirdOri.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
			{
				sound.Play();
				Statics.CHAR_SELECT = Statics.BIRDS.BirdOri;

                Statics.MANAGER_SCREEN.Stack["Game"].Reset();
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Game"];
				Statics.GAME_STATE = Statics.STATE.Playing;
			}
			else if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _charBirdOrange.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
			{
				sound.Play();
				Statics.CHAR_SELECT = Statics.BIRDS.BirdOrange;

                Statics.MANAGER_SCREEN.Stack["Game"].Reset();
                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Game"];
				Statics.GAME_STATE = Statics.STATE.Playing;
			}

			if (Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.Back) || Statics.MANAGER_INPUT.IsRightMouseClicked() || Statics.MANAGER_INPUT.IsKeyPressed(Keys.Escape))
			{
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Level"];
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
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Level"];

			}
		}
	}
}
