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
    public class Beetle : IAnimatedSprite
    {
        //Field
        private PyramidPanic game;
        private Texture2D texture;
        private Vector2 position;
        private Rectangle rectangle;
        private iBeetle state;
        private float speed;
        

        //Properties
        public float Speed
        {
            get { return this.speed; }
        }
        public Vector2 Position
        {
            get { return this.position;  }
            set { 
                    this.position = value;
                    this.rectangle.X = (int)this.position.X + 16;
                    this.rectangle.Y = (int)this.position.Y + 16;
                }
        }
        public PyramidPanic Game
        {
            get { return this.game; }
        }

        public Texture2D Texture
        {
            get { return this.texture; }
        }

        public Rectangle Rectangle
        {
            get { return this.rectangle; }
        }

        public iBeetle State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        //Constructor
        public Beetle(PyramidPanic game, Vector2 position, float speed)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"PlaySceneAssets\Beetles\Beetle");
            this.speed = speed;
            this.position = position;
            this.rectangle = new Rectangle((int)this.position.X, (int)this.position.Y, this.texture.Width/4, this.texture.Height);
            this.state = new WalkUp(this);
        }

        //Update
        public void Update(GameTime gameTime)
        {
            this.state.Update(gameTime);
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.state.Draw(gameTime);                                       
        }



    }
}
