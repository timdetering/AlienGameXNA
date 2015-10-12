//-----------------------------------------------------------------------------
// AlienGame.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienGameSample
{
    /// <summary>
    /// This is the main type for your game.  All of the logic for the game is
    /// handled inside of a GameScreen, so Game1 is just used to setup the 
    /// starting screens.
    /// </summary>
    public class AlienGame : Game
    {
        GraphicsDeviceManager graphics;
        ScreenManager screenManager;

        public AlienGame()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = 240;
            graphics.PreferredBackBufferHeight = 320;

            Content.RootDirectory = "Content";
           
            screenManager = new ScreenManager(this);
            Components.Add(screenManager);

            // Add the background screen
            screenManager.AddScreen(new BackgroundScreen());

            // This loading screen pre-loads all content the game needs.  It
            // doesn't draw anything, so the user sees the background screen
            // then the title and menus pop up.
            screenManager.AddScreen(new LoadingScreen());
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            using (AlienGame game = new AlienGame())
            {
                game.Run();
            }
        }
    }
}

