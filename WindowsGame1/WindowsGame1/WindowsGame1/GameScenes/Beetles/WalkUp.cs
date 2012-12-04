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
    public class WalkUp : AnimatedSprite, iBeetle
    {
        //Fields
        private Beetle beetle;
        

        //Constuctor
        public WalkUp(Beetle beetle) : base (beetle)
        {
            this.beetle = beetle;
            this.angle = 0f;
        }

        //Update
        public void Update(GameTime gameTime)
        {
            this.beetle.Position -= new Vector2(0f, this.beetle.Speed);
            if (this.beetle.Position.Y < 32)
            {
                this.beetle.State = new WalkDown(this.beetle);
            }
            base.Update(gameTime);
        }

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);


        }
    }
}
