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
    public class WalkLeft : AnimatedSprite, iScorpion
    {
        //Fields
        private Scorpion scorpion;


        //Constuctor
        public WalkLeft(Scorpion scorpion) : base(scorpion)
        {
            this.scorpion = scorpion;
            this.angle = (float)Math.PI;
        }

        //Update
        public override void Update(GameTime gameTime)
        {
            //loop van links naar rechts
            this.scorpion.Position -= new Vector2(this.scorpion.Speed, 0f);
            if (this.scorpion.Position.X < 32)
            {
                this.scorpion.State = new WalkRight(this.scorpion);
            }
            base.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);


        }
    }
}
