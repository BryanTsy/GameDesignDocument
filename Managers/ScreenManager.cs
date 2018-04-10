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
            Death,
            Debug,
			Characters,
            Game,
            Level,
            Title,
            Credit
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
            _stack.Add("Cursor", new Screens.CursorScreen());
            _stack.Add("Death", new Screens.DeathScreen());
            _stack.Add("Debug", new Screens.DebugScreen());
            _stack.Add("Game", new Screens.GameScreen());
            _stack.Add("Level", new Screens.LevelScreen());
            _stack.Add("Title", new Screens.TitleScreen());
			_stack.Add("Characters", new Screens.CharSelectScreen());
            _stack.Add("Credit", new Screens.Credit());
            
        }

        public void Update()
        {
            
        }
    }
}
