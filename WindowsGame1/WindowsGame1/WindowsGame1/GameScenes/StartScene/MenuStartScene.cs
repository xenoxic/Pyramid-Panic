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
    public class MenuStartScene
    {
        private enum ButtonState { Start, Load, Help, Scores, Quit, LevelEditor }
        //Fields
        private PyramidPanic game;
        private Image start, load, help, scores, quit, leveleditor;
        private ButtonState buttonState;
        private Color buttonColorActive = Color.DarkGoldenrod;
        private int top, left, space;
        

        //Constructpr

        public MenuStartScene(PyramidPanic game)
        {
            this.game = game;
            this.Initialize();

        }

        //Initialize
        private void Initialize()
        {
            this.buttonState = ButtonState.Start;
            this.top = 430;
            this.left = 4;
            this.space = 107;
            this.Loadcontent();
        }
        
        //Loadcontent
        private void Loadcontent()
        {
            this.start = new Image(this.game, 
                @"StartSceneAssets\Button_start",new Vector2(this.left, this.top));
            this.load = new Image(this.game,
                @"StartSceneAssets\Button_load", new Vector2(this.left + this.space,  this.top));
            this.help = new Image(this.game,
                @"StartSceneAssets\Button_help", new Vector2(this.left + 2 * this.space, this.top));
            this.scores = new Image(this.game,
                @"StartSceneAssets\Button_scores", new Vector2(this.left + 3 * this.space, this.top));
            this.quit = new Image(this.game,
                @"StartSceneAssets\Button_quit", new Vector2(this.left + 4 * this.space, this.top));
            this.leveleditor = new Image(this.game,
                @"StartSceneAssets\Button_leveleditor", new Vector2(this.left + 5 * this.space, this.top));


        }

        
        //Update 
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                if (this.buttonState < ButtonState.LevelEditor)
                {
                    this.buttonState++;
                }
            }

            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                if (this.buttonState > ButtonState.Start)
                {
                    this.buttonState--;
                }
            }

            if ((this.buttonState == ButtonState.Start) ||
                (this.start.Rectangle.Intersects(Input.MouseRectangle()))) 
            {
                this.buttonState = ButtonState.Start;
                if (Input.MouseEdgeDetectPressLeft() && this.help.Rectangle.Intersects(Input.MouseRectangle()) || Input.EdgeDetectKeyDown(Keys.Enter))
                this.game.GameState = new PlayScene(this.game);  
            }

            if ((this.buttonState == ButtonState.Help) ||
                (this.help.Rectangle.Intersects(Input.MouseRectangle())))
            {
                this.buttonState = ButtonState.Help;
                if (Input.MouseEdgeDetectPressLeft() && this.help.Rectangle.Intersects(Input.MouseRectangle()) || Input.EdgeDetectKeyDown(Keys.Enter)) 
                {
                    this.game.GameState = new HelpScene(this.game);
                }
            }

            if ((this.buttonState == ButtonState.Load) ||
                (this.load.Rectangle.Intersects(Input.MouseRectangle())))
            {
                this.buttonState = ButtonState.Load;
                if (Input.MouseEdgeDetectPressLeft() && this.help.Rectangle.Intersects(Input.MouseRectangle()) || Input.EdgeDetectKeyDown(Keys.Enter))
                {
                    this.game.GameState = new LoadScene(this.game);
                }
            }

            if ((this.buttonState == ButtonState.Scores) ||
                (this.scores.Rectangle.Intersects(Input.MouseRectangle())))
            {
                this.buttonState = ButtonState.Scores;
                if (Input.MouseEdgeDetectPressLeft() && this.help.Rectangle.Intersects(Input.MouseRectangle()) || Input.EdgeDetectKeyDown(Keys.Enter))
                {
                    this.game.GameState = new ScoreScene(this.game);
                }
            }
            if ((this.buttonState == ButtonState.Quit) ||
                (this.quit.Rectangle.Intersects(Input.MouseRectangle())))
            {
                this.buttonState = ButtonState.Quit;
                if (Input.MouseEdgeDetectPressLeft() && this.help.Rectangle.Intersects(Input.MouseRectangle()) || Input.EdgeDetectKeyDown(Keys.Enter))
                {
                    this.game.GameState = new QuitScene(this.game);
                }
            }
            if ((this.buttonState == ButtonState.LevelEditor) ||
                (this.leveleditor.Rectangle.Intersects(Input.MouseRectangle())))
            {
                this.buttonState = ButtonState.LevelEditor;
                if (Input.MouseEdgeDetectPressLeft() && this.help.Rectangle.Intersects(Input.MouseRectangle()) || Input.EdgeDetectKeyDown(Keys.Enter))
                {
                    this.game.GameState = new LevelEditorScene(this.game);
                }
            }
        }



        //Draw
        public void Draw(GameTime gameTime)
        {
            Color buttonColorStart = Color.White;
            Color buttonColorLoad = Color.White;
            Color buttonColorHelp = Color.White;
            Color buttonColorScores = Color.White;
            Color buttonColorQuit = Color.White;
            Color buttonColorLeveleditor = Color.White; 

            //switchcase
            switch( this.buttonState )
            {
                case ButtonState.Start:
                    buttonColorStart = this.buttonColorActive;
                    break;
                case ButtonState.Load:
                    buttonColorLoad = this.buttonColorActive;
                    break;
                case ButtonState.Help:
                    buttonColorHelp = this.buttonColorActive;
                    break;
                case ButtonState.Scores:
                    buttonColorScores = this.buttonColorActive;
                    break;
                case ButtonState.Quit:
                    buttonColorQuit = this.buttonColorActive;
                    break;
                case ButtonState.LevelEditor:
                    buttonColorLeveleditor = this.buttonColorActive;
                    break;
                default:
                    break;
            }
            

            this.start.Draw(this.game.SpriteBatch, buttonColorStart);
            this.load.Draw(this.game.SpriteBatch, buttonColorLoad);
            this.help.Draw(this.game.SpriteBatch, buttonColorHelp);
            this.scores.Draw(this.game.SpriteBatch, buttonColorScores);
            this.quit.Draw(this.game.SpriteBatch, buttonColorQuit);
            this.leveleditor.Draw(this.game.SpriteBatch, buttonColorLeveleditor);
        }



    }
}
