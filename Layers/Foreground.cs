using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird.Layers
{
    class Foreground
    {
        public Dictionary<string, ParallaxBackground> ForegroundLayer_Stack;
        public Dictionary<string, ParallaxBackground> ForegroundLayer_Stack2;

        public Foreground()
        {
            this.ForegroundLayer_Stack = new Dictionary<string, ParallaxBackground>();
            this.ForegroundLayer_Stack2 = new Dictionary<string, ParallaxBackground>();
        }

        public void LoadContent()
        {
            AddBackgrounds();
        }

        public void Update()
        {
            if (Statics.EasterCount == 3)
            {
                foreach (ParallaxBackground layer in this.ForegroundLayer_Stack2.Values)
                {
                    layer.Update(Statics.GAME_GAMETIME);
                }
            }
            else
            {
                foreach (ParallaxBackground layer in this.ForegroundLayer_Stack.Values)
                {
                    layer.Update(Statics.GAME_GAMETIME);
                }
            }
        }

        public void Draw()
        {
            if (Statics.EasterCount == 3)
            {
                foreach (ParallaxBackground layer in this.ForegroundLayer_Stack2.Values)
                {
                    layer.Draw(Statics.GAME_SPRITEBATCH, Color.White);
                }
            }
            else
            {
                foreach (ParallaxBackground layer in this.ForegroundLayer_Stack.Values)
                {
                    layer.Draw(Statics.GAME_SPRITEBATCH, Color.White);
                }
            }
        }

        public void ResetBackgrounds()
        {
            this.ForegroundLayer_Stack.Clear();
            this.ForegroundLayer_Stack2.Clear();

            AddBackgrounds();
        }

        private void AddBackgrounds()
        {
            this.ForegroundLayer_Stack.Add("Floor", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_ground", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -4, true, true));
            this.ForegroundLayer_Stack.Add("Water1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_water_1", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1, false, false));
            this.ForegroundLayer_Stack.Add("Water2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_water_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -2, false, false));
            this.ForegroundLayer_Stack.Add("Water3", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_water_3", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1, false, false));

            this.ForegroundLayer_Stack2.Add("Floor", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_ground", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -4, true, true));
            this.ForegroundLayer_Stack2.Add("Water1", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_water_1", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -1, false, false));
            this.ForegroundLayer_Stack2.Add("Water2", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\flappy_water_2", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -2, false, false));
            this.ForegroundLayer_Stack2.Add("Spaceship", new ParallaxBackground(Statics.GAME_CONTENT, "Textures\\Background\\spaceship", Statics.GAME_WIDTH, Statics.GAME_HEIGHT, -15, true, true));

        }
    }
}
