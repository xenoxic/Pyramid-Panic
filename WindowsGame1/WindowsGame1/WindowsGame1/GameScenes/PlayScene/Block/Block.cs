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
    public enum BlockCollision {Passable, NotPassable}

    public class Block
    {
        //Fields
        private PyramidPanic game;
        private Texture2D texture;
        private Rectangle rectangle;
        private Vector2 position;
        private Char charItem;

        //Constuctor
        public Block(PyramidPanic game, string blockName,
                Vector2 position, BlockCollision blockCollision, Char charItem)
        {
            this.game = game;
            this.texture = game.Content.Load<Texture2D>(@"PlaySceneAssets\Block\" + blockName);
            this.rectangle = new Rectangle((int)position.X, (int)position.Y, this.texture.Width, this.texture.Height);
            this.position = position;
            this.charItem = charItem;
        }

        public void Draw(GameTime gameTime)
        {
            this.game.SpriteBatch.Draw(this.texture, this.position, Color.White);
        }

    }
}
