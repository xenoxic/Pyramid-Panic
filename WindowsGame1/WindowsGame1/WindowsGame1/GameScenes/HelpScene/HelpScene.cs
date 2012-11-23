﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    public class HelpScene : IStateGame
    {
        //Fields
        private PyramidPanic game;

        //Constuctor
        public HelpScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();
        }

        //Initialize
        public void Initialize()
        {
            this.LoadContent();
        }

        //Loadcontent
        public void LoadContent()
        {
            if (Input.EdgeDetectKeyDown(Keys.Escape))
            {
                this.game.GameState = new StartScene(this.game);
            }
        }

        //Update
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Escape))
            {
                this.game.GameState = new StartScene(this.game);
            }
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Green);
        }

    }
}
