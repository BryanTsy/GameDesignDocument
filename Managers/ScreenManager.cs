﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird.Managers
{
    public class ScreenManager
    {
        public enum ScreenType
        {
            Cursor,
            Splash,
            Death,
            Debug,
			Characters,
            Game,
            Level,
            Title,
            Credit,
            Instructions

        }

        private Dictionary<string, Screens.Screen> _stack;
        public Dictionary<string, Screens.Screen> Stack { get { return _stack; } }
        
        public ScreenManager()
        {
            Statics.MANAGER_SCREEN = this;
            _stack = new Dictionary<string, Screens.Screen>();
        }

        public void LoadContent()
        {
            _stack.Add("Splash", new Screens.SplashScreen());
            _stack.Add("Cursor", new Screens.CursorScreen());
            _stack.Add("Death", new Screens.DeathScreen());
            _stack.Add("Debug", new Screens.DebugScreen());
            _stack.Add("Game", new Screens.GameScreen());
            _stack.Add("Level", new Screens.LevelScreen());
            _stack.Add("Title", new Screens.TitleScreen());
			_stack.Add("Characters", new Screens.CharSelectScreen());
            _stack.Add("Credit", new Screens.Credit());
            _stack.Add("Instructions", new Screens.Instructions());

        }

        public void Update()
        {
            
        }
    }
}
