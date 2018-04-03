using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird.Layers
{
    class Background
    {
        public Dictionary<string, ParallaxBackground> BackgroundLayer_Stack;
        //mycode
        public Dictionary<string, ParallaxBackground> BackgroundLayer_Stack2;
        public Dictionary<string, ParallaxBackground> BackgroundLayer_Stack3;

        public Background()
        {
            this.BackgroundLayer_Stack = new Dictionary<string, ParallaxBackground>();
            this.BackgroundLayer_Stack2 = new Dictionary<string, ParallaxBackground>();
            this.BackgroundLayer_Stack3 = new Dictionary<string, ParallaxBackground>();
        }

        public void LoadContent()
        {
            AddBackgrounds();
        }

        public void Update()
        {
            //mycode
            int scoring = Statics.GAME_SCORE;
            if (scoring == 0 || scoring < 3)
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack.Values)
                {
                    layer.Update(Statics.GAME_GAMETIME);
                }
            }
            else if (scoring % 3 == 0)
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack2.Values)
                {
                    layer.Update(Statics.GAME_GAMETIME);
                }
            }
            else if (scoring % 3 == 1)
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack2.Values)
                {
                    layer.Update(Statics.GAME_GAMETIME);
                }
            }
            else
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack3.Values)
                {
                    layer.Update(Statics.GAME_GAMETIME);
                }
            }

            //foreach (ParallaxBackground layer in this.BackgroundLayer_Stack.Values)
            //{
            //layer.Update(Statics.GAME_GAMETIME);
            //}
        }

        public void Draw()
        {
            int scoring = Statics.GAME_SCORE;
            if (scoring == 0 || scoring < 3)
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack.Values)
                {
                    layer.Draw(Statics.GAME_SPRITEBATCH, Color.White);
                }
            }
            else if (scoring % 3 == 0)
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack2.Values)
                {
                    layer.Draw(Statics.GAME_SPRITEBATCH, Color.White);
                }
            }
            else if (scoring % 3 == 1)
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack2.Values)
                {
                    layer.Draw(Statics.GAME_SPRITEBATCH, Color.White);
                }
            }
            else
            {
                foreach (ParallaxBackground layer in this.BackgroundLayer_Stack3.Values)
                {
                    layer.Draw(Statics.GAME_SPRITEBATCH, Color.White);
                }
            }

            //foreach (ParallaxBackground layer in this.BackgroundLayer_Stack.Values)
            //{
            // layer.Draw(Statics.GAME_SPRITEBATCH, Color.White);
            //}
        }

        public void ResetBackgrounds()
        {
            this.BackgroundLayer_Stack.Clear();
            this.BackgroundLayer_Stack2.Clear();
            this.BackgroundLayer_Stack3.Clear();

            AddBackgrounds();
        }

        private void AddBackgrounds()
        {
            //background 1
            this.BackgroundLayer_Stack.Add("Clouds1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_1", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, 0f, true, true));
            this.BackgroundLayer_Stack.Add("Clouds2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -0.5f, true, true));
            this.BackgroundLayer_Stack.Add("Clouds3", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_3", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.0f, true, true));

            this.BackgroundLayer_Stack.Add("Hills1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_hills_1", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.5f, true, true));
            this.BackgroundLayer_Stack.Add("Hills2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_hills_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -2.0f, true, true));

            this.BackgroundLayer_Stack.Add("Houses", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_houses", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.0f, true, true));

            //mycode
            //background 2
            this.BackgroundLayer_Stack2.Add("Clouds1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_1", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, 0f, true, true));
            this.BackgroundLayer_Stack2.Add("Clouds2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -0.5f, true, true));
            this.BackgroundLayer_Stack2.Add("Clouds3", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_3", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.0f, true, true));

            this.BackgroundLayer_Stack2.Add("Hills1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_hills_dark", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.5f, true, true));
            this.BackgroundLayer_Stack2.Add("Hills2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_hills_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -2.0f, true, true));

            this.BackgroundLayer_Stack2.Add("Houses2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_houses2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.0f, true, true));

            //background 3
            this.BackgroundLayer_Stack3.Add("Clouds1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_1", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, 0f, true, true));
            this.BackgroundLayer_Stack3.Add("Clouds2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -0.5f, true, true));
            this.BackgroundLayer_Stack3.Add("Clouds3", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_clouds_3", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.0f, true, true));

            this.BackgroundLayer_Stack3.Add("Hills1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_hills_dark", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.5f, true, true));
            this.BackgroundLayer_Stack3.Add("Hills2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_hills_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -2.0f, true, true));

            this.BackgroundLayer_Stack3.Add("Houses3", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_houses3", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1.0f, true, true));

        }
    }
}
