using System;
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

    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //Fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private StartScene startScene;
 

        //Properties
        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
        }

        //Consturctor
        public PyramidPanic()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.IsMouseVisible = true;
            this.Window.Title = "Pyramid Panic";
            this.graphics.PreferredBackBufferWidth = 640;
            this.graphics.PreferredBackBufferHeight = 480;
            this.graphics.ApplyChanges();
            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.spriteBatch = new SpriteBatch(GraphicsDevice);
            this.startScene = new StartScene(this);

 
        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }


        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.Black);
            this.spriteBatch.Begin();
            this.startScene.Draw(gameTime);
            this.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
