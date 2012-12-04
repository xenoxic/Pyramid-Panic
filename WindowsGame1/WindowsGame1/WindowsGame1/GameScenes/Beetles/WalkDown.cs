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
    public class WalkDown : AnimatedSprite, iBeetle
    {
        //Fields
        private Beetle beetle;
        
        //Constuctor
        public WalkDown(Beetle beetle) : base(beetle)
        {
            this.beetle = beetle;
            this.angle = (float)Math.PI;
        }

        //Update
        public void Update(GameTime gameTime)
        {
            //loop van links naar rechts
            this.beetle.Position += new Vector2(0f, this.beetle.Speed);
            if (this.beetle.Position.Y > 384)
            {
                this.beetle.State = new WalkUp(this.beetle);
            }
            base.Update(gameTime);
        }

        public void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
