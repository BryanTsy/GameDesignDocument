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
		private Rectangle _charBirdOri;
		private Rectangle _charBirdOrange;

		public CharSelectScreen()
		{

		}

		public override void LoadContent()
		{
			_charBirdOri = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOri"].X, (int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOri"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"].Height);
			_charBirdOrange = new Rectangle((int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOrange"].X, (int)Statics.MANAGER_UI.TextureVectors["Characters\\CharactersOrange"].Y, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOrange"].Width, Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOrange"].Height);

			base.LoadContent();
		}

		public override void Update()
		{
			// Input : Mouse

			if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _charBirdOri.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
			{
				Statics.CHAR_SELECT = Statics.BIRDS.BirdOri;
				Statics.GAME_WORLD = Statics.WORLD.Pipes;

				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Game"];
				Statics.GAME_STATE = Statics.STATE.Playing;
			}
			else if ((Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.A) || Statics.MANAGER_INPUT.IsLeftMouseClicked()) && _charBirdOrange.Contains(Statics.MANAGER_INPUT.GetCursorPosition()))
			{
				Statics.CHAR_SELECT = Statics.BIRDS.BirdOrange;
				Statics.GAME_WORLD = Statics.WORLD.Pipes;

				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Game"];
				Statics.GAME_STATE = Statics.STATE.Playing;
			}

			if (Statics.MANAGER_INPUT.IsGamepadPressed(Buttons.Back) || Statics.MANAGER_INPUT.IsRightMouseClicked() || Statics.MANAGER_INPUT.IsKeyPressed(Keys.Escape))
			{
				Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Level"];
			}

			base.Update();
		}

		public override void Draw()
		{
			base.Draw();
		}
	}
}
