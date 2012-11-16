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
    public static class Input
    {
        //Fields
        private static KeyboardState ks, oks;
        private static MouseState ms, oms;
        private static Rectangle mouseRectangle;

        //Constructor
        static Input()
        {
            mouseRectangle = new Rectangle(0, 0, 1, 1);
            ks = Keyboard.GetState();
            ms = Mouse.GetState();
            oks = ks;
            oms = ms;
        }

        //Update methode
        public static void Update()
        {
            oks = ks;
            oms = ms;
            ks = Keyboard.GetState();
            ms = Mouse.GetState();
        }   
            
        //LevelDetecter voor toetsen
        public static bool DetectKeyDown(Keys key)
        {
            return ks.IsKeyDown(key);
        }
        
        //Edgedetect voor de toetsenbordknoppen
        public static bool EdgeDetectKeyDown(Keys key)
        {
            return (ks.IsKeyDown(key) && oks.IsKeyUp(key));
        }

        //Edgedetector voor een linksklik van de muis
        public static bool MouseEdgeDetectPressLeft()
        {
            return (ms.LeftButton == ButtonState.Pressed && oms.LeftButton == ButtonState.Released);
        }
        //Edgedetector voor een rechtsklik van de muis
        public static bool MouseEdgeDetectPressRight()
        {
            return (ms.RightButton == ButtonState.Pressed && oms.RightButton == ButtonState.Released);
        }

        //Positie van de muis
        public static Vector2 MousePosition()
        {
            return new Vector2(ms.X, ms.Y);
        }

        //Positie van de rectangle
        public static Rectangle MouseRectangle()
        {
            mouseRectangle.X = ms.X;
            mouseRectangle.Y = ms.Y;
            return mouseRectangle;
        }

    }
}
