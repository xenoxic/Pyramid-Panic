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
    public class WalkLeft : iScorpion
    {
        //Fields
        private Scorpion scorpion;
        private int[] xValue = { 0, 32, 64, 96 };
        private int i = 0;
        private float timer;

        //Constuctor
        public WalkLeft(Scorpion scorpion)
        {
            this.scorpion = scorpion;
        }

        //Update
        public void Update(GameTime gameTime)
        {
            //loop van links naar rechts
            this.scorpion.Position -= new Vector2(this.scorpion.Speed, 0f);
            if (this.scorpion.Position.X < 32)
            {
                this.scorpion.State = new WalkRight(this.scorpion);
            }
            this.timer += (float)gameTime.ElapsedGameTime.TotalSeconds;
            //Console.WriteLine(this.timer);
            if (this.timer > 1f / 9f)
            {
                this.timer = 0;
                this.i++;
                if (this.i > 2)
                {
                    this.i = 0;
                }
            }
        }

        public void Draw(GameTime gameTime)
        {
            this.scorpion.Game.SpriteBatch.Draw(this.scorpion.Texture,
                                       this.scorpion.Rectangle,
                                       new Rectangle(this.xValue[this.i], 0, 32, 32),
                                       Color.White,
                                       (float)Math.PI,
                                       new Vector2(16f, 16f),
                                       SpriteEffects.None,
                                       0f);


        }
    }
}
