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
    public class Panel
    {
        //Field
        private PyramidPanic game;
        private Vector2 position;
        private List<Image> images;
        private SpriteFont font;




        //Constructor
        public Panel(PyramidPanic game, Vector2 position)
        {
            this.game = game;
            this.position = position;
            this.Initialize();
        }

        private void Initialize()
        {
            this.font = this.game.Content.Load<SpriteFont>(@"PlaySceneAssets\Fonts\Arial");
            this.images = new List<Image>();
            this.LoadContent();
        }

        private void LoadContent()
        {
            this.images.Add(new Image(this.game, @"PlaySceneAssets\Panel\Panel", this.position));
            this.images.Add(new Image(this.game, @"PlaySceneAssets\Panel\Lives", this.position
                                + new Vector2(2.5f * 32f, 0f)));
            this.images.Add(new Image(this.game, @"PlaySceneAssets\Treasures\Scarab", this.position
                                + new Vector2(7.5f * 32f, 0)));
          
        }

        public void Draw(GameTime gameTime)
        {
            foreach (Image image in this.images)
            {
                image.Draw(gameTime);
            }
            this.game.SpriteBatch.DrawString(this.font, 
                                             "999", 
                                             this.position + new Vector2(3.8f * 32f, -2f), 
                                             Color.Yellow,
                                             0f,
                                             Vector2.Zero, 
                                             1f, 
                                             SpriteEffects.None, 
                                             1f);
            this.game.SpriteBatch.DrawString(this.font,
                                             "1",
                                             this.position + new Vector2(8.8f * 32f, -3f),
                                             Color.Yellow,
                                             0f,
                                             Vector2.Zero,
                                             1f,
                                             SpriteEffects.None,
                                             1f);
            this.game.SpriteBatch.DrawString(this.font,
                                             "000000",
                                             this.position + new Vector2(16.5f * 32f, -3f),
                                             Color.Yellow,
                                             0f,
                                             Vector2.Zero,
                                             1f,
                                             SpriteEffects.None,
                                             1f);
        }


    }
}
