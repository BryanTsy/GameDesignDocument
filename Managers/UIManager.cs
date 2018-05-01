using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird.Managers
{
    class UIManager
    {
        public Dictionary<string, Vector2> TextVectors;
        public Dictionary<string, Vector2> TextureVectors;

        private float _screenCenterX;
        private float _screenCenterY;

        private float _screenThirdX;
        private float _screenThirdY;

        private float _screenQuarterX;
        private float _screenQuarterY;

        private int Pcount = 3;
        private int SMPcount = 3;

        public UIManager()
        {
            Statics.MANAGER_UI = this;

            TextVectors = new Dictionary<string, Vector2>();
            TextureVectors = new Dictionary<string, Vector2>();

            _screenCenterX = Statics.GAME_WIDTH / 2;
            _screenCenterY = Statics.GAME_HEIGHT / 2;

            _screenThirdX = Statics.GAME_WIDTH / 3;
            _screenThirdY = Statics.GAME_HEIGHT / 3;

            _screenQuarterX = Statics.GAME_WIDTH / 4;
            _screenQuarterY = Statics.GAME_HEIGHT / 4;
        }

        public void LoadContent()
        {

            #region Screen : Splash


            TextureVectors.Add("Splash\\banner", new Vector2((float)(_screenCenterX - Statics.MANAGER_TEXTURES.Textures["UI\\banner"].Width / 2), (float)(_screenThirdY * 1.5 - Statics.MANAGER_TEXTURES.Textures["UI\\banner"].Height / 2) - 35));

            #endregion

            #region Screen : Title


            TextVectors.Add("Title\\Title", Statics.MANAGER_FONT.Library["Large"].MeasureString(Statics.GAME_TITLE) / 2);
            TextVectors.Add("Title\\Start", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Start") / 2);
            TextVectors.Add("Title\\Exit", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Exit") / 2);
            TextVectors.Add("Title\\Credit", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Credit") / 2);
            TextVectors.Add("Title\\Instructions", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Instructions") / 2);
            TextVectors.Add("Title\\Mute", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Mute") / 2);

            TextureVectors.Add("Title\\Title", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Title"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Title"].Height / 2) - 310));
            TextureVectors.Add("Title\\Start", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) - 110));
            TextureVectors.Add("Title\\Exit", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) + 0));
            TextureVectors.Add("Title\\Credit", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) + 115));
            TextureVectors.Add("Title\\Instructions", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) - 220));
            TextureVectors.Add("Title\\Mute", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) + 225));
            #endregion

            #region Screen : Level
            TextVectors.Add("Level\\Back", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Back") / 2);
            TextVectors.Add("Level\\Title", Statics.MANAGER_FONT.Library["Large"].MeasureString("Select level") / 2);
         
			TextureVectors.Add("Level\\Back", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) + 130));
            TextureVectors.Add("Level\\Pipe", new Vector2((float)(_screenQuarterX - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonPipe"].Width / 2), (float)(_screenThirdY * 2 - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonPipe"].Height / 2) - 60));
            TextureVectors.Add("Level\\Bullet", new Vector2((float)(_screenCenterX - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonBullet"].Width / 2), (float)(_screenThirdY * 2 - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonBullet"].Height / 2) - 60));
            TextureVectors.Add("Level\\Paratroopa", new Vector2((float)(Statics.GAME_WIDTH - _screenQuarterX - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonParatroopa"].Width / 2), (float)(_screenThirdY * 2 - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonParatroopa"].Height / 2) - 60));

            #endregion

			#region Screen : Characters
			TextVectors.Add("Characters\\Back", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Back") / 2);
			TextureVectors.Add("Characters\\Back", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) + 130));
			TextureVectors.Add("Characters\\CharactersOri", new Vector2((float)(_screenQuarterX - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"].Width / 2), (float)(_screenThirdY* 1.5 - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"].Height) - 60));
            TextureVectors.Add("Characters\\CharactersOrange", new Vector2((float)(_screenCenterX - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOrange"].Width / 2), (float)(_screenThirdY* 1.5 - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"].Height) - 60));

			#endregion

            #region Screen : Credit
            TextVectors.Add("Credit\\Title", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Development Project 1 (Operation Flappy)") / 2);
            TextVectors.Add("Credit\\Content1", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Improvements have been made by:") / 2);
            TextVectors.Add("Credit\\Content2", Statics.MANAGER_FONT.Library["Small"].MeasureString("Bryan Ting") / 2);
            TextVectors.Add("Credit\\Content3", Statics.MANAGER_FONT.Library["Small"].MeasureString("Wilson To") / 2);
            TextVectors.Add("Credit\\Content4", Statics.MANAGER_FONT.Library["Small"].MeasureString("Tey Yee") / 2);
            TextVectors.Add("Credit\\Content5", Statics.MANAGER_FONT.Library["Small"].MeasureString("Casimir") / 2);
            TextVectors.Add("Credit\\Content6", Statics.MANAGER_FONT.Library["Small"].MeasureString("Dastan") / 2);
            TextVectors.Add("Credit\\Content7", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Original Version Author") / 2);
            TextVectors.Add("Credit\\Content8", Statics.MANAGER_FONT.Library["Small"].MeasureString("Sranshaft") / 2);

            TextVectors.Add("Credit\\Back", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Credit") / 2);
            TextureVectors.Add("Credit\\Back", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) + 150));


            #endregion

            #region Screen : Instructions
            TextVectors.Add("Instructions\\Title", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Instructions for Flappy Bird") / 2);
            TextVectors.Add("Instructions\\Content1", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Buttons to click for jump:") / 2);
            TextVectors.Add("Instructions\\Content2", Statics.MANAGER_FONT.Library["Small"].MeasureString("Space bar") / 2);
            TextVectors.Add("Instructions\\Content3", Statics.MANAGER_FONT.Library["Small"].MeasureString("Left mouse click") / 2);

            TextVectors.Add("Instructions\\Content7", Statics.MANAGER_FONT.Library["Regular"].MeasureString("That's All! Simple n Easy Game") / 2);
            TextVectors.Add("Instructions\\Content8", Statics.MANAGER_FONT.Library["Small"].MeasureString("Enjoy!!!") / 2);

            TextVectors.Add("Instructions\\Back", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Instructions") / 2);
            TextureVectors.Add("Instructions\\Back", new Vector2((Statics.GAME_WIDTH / 2) - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Width / 2), (Statics.GAME_HEIGHT / 3) * 2 - (Statics.MANAGER_TEXTURES.Textures["UI\\Button"].Height / 2) + 150));


            #endregion

            #region Screen : Game

            TextVectors.Add("Game\\Score", new Vector2(20, 20));
            TextVectors.Add("Game\\Level", new Vector2(20, 50));
            TextVectors.Add("Game\\GPU", new Vector2(20, 80));
            TextVectors.Add("Game\\SM", new Vector2(20, 110));

            #endregion

            #region Screen : Paused

            TextVectors.Add("Pause\\Title", Statics.MANAGER_FONT.Library["Large"].MeasureString("Paused") / 2);
            TextVectors.Add("Pause\\Continue", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Press ENTER to continue") / 2);
			TextVectors.Add("Pause\\Main", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Press ESC to Main Menu") / 2);
			TextVectors.Add("Pause\\Exit", Statics.MANAGER_FONT.Library["Regular"].MeasureString("Press ESC twice to quit") / 2);
            
            TextureVectors.Add("Pause\\Exit", new Vector2((float)(Statics.GAME_WIDTH - _screenThirdX - Statics.MANAGER_TEXTURES.Textures["UI\\ButtonExit"].Width), _screenThirdY * 2));

            #endregion

            #region Screen : Game over

            TextVectors.Add("GameOver\\Title", Statics.MANAGER_FONT.Library["Large"].MeasureString("Game Over") / 2);
            TextVectors.Add("GameOver\\Score", Statics.MANAGER_FONT.Library["Extra"].MeasureString(Statics.GAME_SCORE.ToString("00")) / 2);
            TextVectors.Add("GameOver\\HighScore", Statics.MANAGER_FONT.Library["Large"].MeasureString("New high score") / 2);
            TextVectors.Add("GameOver\\Restart", Statics.MANAGER_FONT.Library["Large"].MeasureString("Restart") / 2);
            TextVectors.Add("GameOver\\TimeFlapped", Statics.MANAGER_FONT.Library["Regular"].MeasureString(string.Format("You flapped for {0} seconds", Statics.TIME_ACTUALGAMETIME.TotalSeconds.ToString("00"))) / 2);

            #endregion
        }

        public void Update()
        {
            // Get common dimensions
            _screenCenterX = Statics.GAME_WIDTH / 2;
            _screenCenterY = Statics.GAME_HEIGHT / 2;

            _screenThirdX = Statics.GAME_WIDTH / 3;
            _screenThirdY = Statics.GAME_HEIGHT / 3;

            _screenQuarterX = Statics.GAME_WIDTH / 4;
            _screenQuarterY = Statics.GAME_HEIGHT / 4;

            // Get 'Score' position
            TextVectors["GameOver\\Score"] = Statics.MANAGER_FONT.Library["Extra"].MeasureString(Statics.GAME_SCORE.ToString("00")) / 2;

            // Get 'Total time flapped' position
            TextVectors["GameOver\\TimeFlapped"] = Statics.MANAGER_FONT.Library["Regular"].MeasureString(string.Format("You flapped for {0} seconds", Statics.TIME_ACTUALGAMETIME.TotalSeconds.ToString("00"))) / 2;
            
            // Update cursor
            Statics.MANAGER_SCREEN.Stack["Cursor"].Update();
        }

        public void Draw()
        {
            Statics.GAME_SPRITEBATCH.Begin();
            if (Statics.SCREEN_CURRENT == Statics.MANAGER_SCREEN.Stack["Splash"])
            {
                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\banner"], TextureVectors["Splash\\banner"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], Statics.GAME_WAIT, new Vector2(_screenCenterX + 50, _screenQuarterY + 425), Color.White, 0.0f, TextVectors["Title\\Title"], 1.0f, SpriteEffects.None, 1.0f);
            }
            else if (Statics.SCREEN_CURRENT == Statics.MANAGER_SCREEN.Stack["Title"])
            {
                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Title"], TextureVectors["Title\\Title"], Color.White);
                Statics.GAME_SPRITEBATCH.Draw(Statics.TEXTURE_PIXEL, new Rectangle(0, 0, Statics.GAME_WIDTH, Statics.GAME_HEIGHT), Statics.COLOR_TITLE);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Large"], Statics.GAME_TITLE, new Vector2(_screenCenterX, _screenQuarterY), Color.White, 0.0f, TextVectors["Title\\Title"], 1.0f, SpriteEffects.None, 1.0f);

                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Title\\Start"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Start", new Vector2(_screenCenterX, _screenThirdY * 2 - 110), Color.White, 0.0f, TextVectors["Title\\Start"], 1.0f, SpriteEffects.None, 1.0f);

                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Title\\Exit"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Exit", new Vector2(_screenCenterX, _screenThirdY * 2 + 0), Color.White, 0.0f, TextVectors["Title\\Exit"], 1.0f, SpriteEffects.None, 1.0f);

                 Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Title\\Credit"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Credit", new Vector2(_screenCenterX, _screenThirdY * 2 + 115), Color.White, 0.0f, TextVectors["Title\\Credit"], 1.0f, SpriteEffects.None, 1.0f);

                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Title\\Instructions"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Instructions", new Vector2(_screenCenterX, _screenThirdY * 2 - 220), Color.White, 0.0f, TextVectors["Title\\Instructions"], 1.0f, SpriteEffects.None, 1.0f);

                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Title\\Mute"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Mute", new Vector2(_screenCenterX, _screenThirdY * 2 + 225), Color.White, 0.0f, TextVectors["Title\\Mute"], 1.0f, SpriteEffects.None, 1.0f);
            }
            else if (Statics.SCREEN_CURRENT == Statics.MANAGER_SCREEN.Stack["Credit"])
                {
                 Statics.GAME_SPRITEBATCH.Draw(Statics.TEXTURE_PIXEL, new Rectangle(0, 0, Statics.GAME_WIDTH, Statics.GAME_HEIGHT), Statics.COLOR_TITLE);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"],"Development Project 1 (Operation Flappy)", new Vector2(_screenCenterX, _screenQuarterY * 2 -300), Color.White, 0.0f, TextVectors["Credit\\Title"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"],"Improvements have been made by:", new Vector2(_screenCenterX, _screenQuarterY * 2 -230), Color.White, 0.0f, TextVectors["Credit\\Content1"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"],"Bryan Ting", new Vector2(_screenCenterX, _screenQuarterY * 2 -160), Color.White, 0.0f, TextVectors["Credit\\Content2"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"],"Wilson To", new Vector2(_screenCenterX, _screenQuarterY * 2 -120), Color.White, 0.0f, TextVectors["Credit\\Content3"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"],"Tey Yee", new Vector2(_screenCenterX, _screenQuarterY * 2 -80), Color.White, 0.0f, TextVectors["Credit\\Content4"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"],"Casimir", new Vector2(_screenCenterX, _screenQuarterY * 2 -40), Color.White, 0.0f, TextVectors["Credit\\Content5"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"],"Dastan", new Vector2(_screenCenterX, _screenQuarterY * 2 -0), Color.White, 0.0f, TextVectors["Credit\\Content6"], 1.0f, SpriteEffects.None, 1.0f);
                 Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"],"Original Version Author", new Vector2(_screenCenterX, _screenQuarterY * 2 +80), Color.White, 0.0f, TextVectors["Credit\\Content7"], 1.0f, SpriteEffects.None, 1.0f);
                 Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"],"Sranshaft", new Vector2(_screenCenterX, _screenQuarterY * 2 +150), Color.White, 0.0f, TextVectors["Credit\\Content8"], 1.0f, SpriteEffects.None, 1.0f);
                 Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Credit\\Back"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Back", new Vector2(_screenCenterX, _screenThirdY * 2 + 150), Color.White, 0.0f, TextVectors["Title\\Credit"], 1.0f, SpriteEffects.None, 1.0f);

                }

            else if (Statics.SCREEN_CURRENT == Statics.MANAGER_SCREEN.Stack["Instructions"])
            {
                Statics.GAME_SPRITEBATCH.Draw(Statics.TEXTURE_PIXEL, new Rectangle(0, 0, Statics.GAME_WIDTH, Statics.GAME_HEIGHT), Statics.COLOR_TITLE);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Instructions for Flappy Bird", new Vector2(_screenCenterX, _screenQuarterY * 2 - 300), Color.White, 0.0f, TextVectors["Instructions\\Title"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Buttons to click for jump:", new Vector2(_screenCenterX, _screenQuarterY * 2 - 230), Color.White, 0.0f, TextVectors["Instructions\\Content1"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], "Space bar", new Vector2(_screenCenterX, _screenQuarterY * 2 - 160), Color.White, 0.0f, TextVectors["Instructions\\Content2"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], "Left mouse click", new Vector2(_screenCenterX, _screenQuarterY * 2 - 120), Color.White, 0.0f, TextVectors["Instructions\\Content3"], 1.0f, SpriteEffects.None, 1.0f);

                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "That's All! Simple n Easy Game", new Vector2(_screenCenterX, _screenQuarterY * 2 + 80), Color.White, 0.0f, TextVectors["Instructions\\Content7"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], "Enjoy!!!", new Vector2(_screenCenterX, _screenQuarterY * 2 + 150), Color.White, 0.0f, TextVectors["Instructions\\Content8"], 1.0f, SpriteEffects.None, 1.0f);
                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Instructions\\Back"], Color.White);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Back", new Vector2(_screenCenterX +80, _screenThirdY * 2 + 150), Color.White, 0.0f, TextVectors["Title\\Instructions"], 1.0f, SpriteEffects.None, 1.0f);

            }


            else if (Statics.SCREEN_CURRENT == Statics.MANAGER_SCREEN.Stack["Level"])
            {
                Statics.GAME_SPRITEBATCH.Draw(Statics.TEXTURE_PIXEL, new Rectangle(0, 0, Statics.GAME_WIDTH, Statics.GAME_HEIGHT), Statics.COLOR_TITLE);
                Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Large"], "Select level", new Vector2(_screenCenterX, _screenQuarterY), Color.White, 0.0f, TextVectors["Level\\Title"], 1.0f, SpriteEffects.None, 1.0f);
				Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Level\\Back"], Color.White);
				Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Back", new Vector2(_screenCenterX, _screenThirdY* 2 + 130), Color.White, 0.0f, TextVectors["Characters\\Back"], 1.0f, SpriteEffects.None, 1.0f);

                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\ButtonPipe"], TextureVectors["Level\\Pipe"], Color.White);
                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\ButtonBullet"], TextureVectors["Level\\Bullet"], Color.White);
                Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\ButtonParatroopa"], TextureVectors["Level\\Paratroopa"], Color.White);
                
            }
			else if (Statics.SCREEN_CURRENT == Statics.MANAGER_SCREEN.Stack["Characters"])
			{
				Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\Button"], TextureVectors["Characters\\Back"], Color.White);
				Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Back", new Vector2(_screenCenterX, _screenThirdY* 2 + 130), Color.White, 0.0f, TextVectors["Characters\\Back"], 1.0f, SpriteEffects.None, 1.0f);
				Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOri"], TextureVectors["Characters\\CharactersOri"], Color.White);
				Statics.GAME_SPRITEBATCH.Draw(Statics.MANAGER_TEXTURES.Textures["UI\\ButtonCharactersOrange"], TextureVectors["Characters\\CharactersOrange"], Color.White);
			}
            else if (Statics.SCREEN_CURRENT == Statics.MANAGER_SCREEN.Stack["Game"])
            {
                if (Statics.GAME_STATE == Statics.STATE.GameOver)
                {
                    Statics.GAME_SPRITEBATCH.Draw(Statics.TEXTURE_PIXEL, new Rectangle(0, 0, Statics.GAME_WIDTH, Statics.GAME_HEIGHT), Statics.COLOR_DEAD);
                    Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Large"], "Game Over", new Vector2(_screenCenterX, _screenQuarterY), Color.White, 0.0f, TextVectors["GameOver\\Title"], 1.0f, SpriteEffects.None, 1.0f);
                    Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Extra"], Statics.GAME_SCORE.ToString("00"), new Vector2(_screenCenterX, _screenCenterY - 30), Color.White, 0.0f, TextVectors["GameOver\\Score"], 1.0f, SpriteEffects.None, 1.0f);
                    Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], string.Format("You flapped for {0} seconds", Statics.TIME_ACTUALGAMETIME.TotalSeconds.ToString("00")), new Vector2(_screenCenterX, _screenCenterY + 160), Color.White, 0.0f, TextVectors["GameOver\\TimeFlapped"], 1.0f, SpriteEffects.None, 1.0f);
                    Pcount = 3;
                    SMPcount = 3;

                    if (Statics.GAME_NEWHIGHSCORE)
                        Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Large"], "New high score", new Vector2(_screenCenterX, _screenCenterY + 100), Color.White, 0.0f, TextVectors["GameOver\\HighScore"], 1.0f, SpriteEffects.None, 1.0f);
                }

                if (Statics.GAME_STATE == Statics.STATE.Paused)
                {
                    Statics.GAME_SPRITEBATCH.Draw(Statics.TEXTURE_PIXEL, new Rectangle(0, 0, Statics.GAME_WIDTH, Statics.GAME_HEIGHT), Statics.COLOR_PAUSED);
                    Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Large"], "Paused", new Vector2(_screenCenterX, _screenQuarterY), Color.Black, 0.0f, TextVectors["Pause\\Title"], 1.0f, SpriteEffects.None, 1.0f);
                    Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Press ENTER to continue", new Vector2(_screenCenterX, _screenThirdY + 50), Color.Black, 0.0f, TextVectors["Pause\\Continue"], 1.0f, SpriteEffects.None, 1.0f);
					Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Press ESC to Main Menu", new Vector2(_screenCenterX, _screenThirdY + 100), Color.Black, 0.0f, TextVectors["Pause\\Main"], 1.0f, SpriteEffects.None, 1.0f);
					Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Regular"], "Press ESC twice to quit", new Vector2(_screenCenterX, _screenThirdY + 150), Color.Black, 0.0f, TextVectors["Pause\\Exit"], 1.0f, SpriteEffects.None, 1.0f);
                }

                if (Statics.GAME_STATE == Statics.STATE.Playing)
                {
                    //power up - jumpboost
                    if (Statics.MANAGER_INPUT.IsKeyPressed(Keys.D1) && Pcount > 0)
                    {
                        Pcount--;
                        Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], string.Format("Glide Power Up: {0}", Pcount.ToString("3")), TextVectors["Game\\GPU"], Color.White);
                    }
                    else
                    {
                        Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], string.Format("Glide Power Up: {0}", Pcount.ToString("0")), TextVectors["Game\\GPU"], Color.White);
                    }

                    //slow motion
                    if (Statics.MANAGER_INPUT.IsKeyPressed(Keys.D3) && SMPcount > 0)
                    {
                        SMPcount--;
                        Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], string.Format("Slow Motion: {0}", SMPcount.ToString("3")), TextVectors["Game\\SM"], Color.White);
                    }
                    else
                    {
                        Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], string.Format("Slow Motion: {0}", SMPcount.ToString("0")), TextVectors["Game\\SM"], Color.White);
                    }

                    Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], string.Format("Score: {0}", Statics.GAME_SCORE.ToString("00")), TextVectors["Game\\Score"], Color.White);
                    Statics.GAME_SPRITEBATCH.DrawString(Statics.MANAGER_FONT.Library["Small"], string.Format("Level: {0}", Statics.GAME_LEVEL.ToString("00")), TextVectors["Game\\Level"], Color.White);
                }
            }

            Statics.MANAGER_SCREEN.Stack["Cursor"].Draw();
            
            Statics.GAME_SPRITEBATCH.End();
        }
    }
}
