using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace FlappyBird.Screens
{
    class SplashScreen : Screen
    {
        //System.Media.SoundPlayer splash = new System.Media.SoundPlayer("Content\\Sounds\\bird.wav");
        private TimeSpan _sample;
        private Stopwatch _stopWatch;
        //private AudioEngine splash;
        // private SoundEffect splash;

        public SplashScreen()
        {
            _sample = TimeSpan.FromSeconds(2);
            _stopWatch = Stopwatch.StartNew();

        }

        public override void LoadContent()
        {

            //splash = Statics.GAME_CONTENT.Load<SoundEffect>("Content\\Sounds\\bird.wav");
            //splash.Play();
            base.LoadContent();
        }

        public override void Update()
        {

            //Statics.GAME_STATE = Statics.STATE.Loading;
            if (_stopWatch.Elapsed > _sample)
            {

                Statics.SCREEN_CURRENT = Statics.MANAGER_SCREEN.Stack["Title"];

            }


        }

        public override void Draw()
        {

            base.Draw();
        }

    }
}
