﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace lab3_game
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D myTexture;
        Vector2 spritePosition = Vector2.Zero;
        int frame = 3;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            myTexture = Content.Load<Texture2D>("NatureSprite");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(85, 133, 50));
            spriteBatch.Begin();
            //BigTree
            spriteBatch.Draw(myTexture, new Vector2(0, 0), new Rectangle(64 * 4, 64 * 2, 64 * 4, 64 * 4), Color.White);
            //Curly Bushes
            spriteBatch.Draw(myTexture, new Vector2(64 * 5, 64), new Rectangle(64, 0, 64, 64), Color.White);
            spriteBatch.Draw(myTexture, new Vector2(64 * 5, 64 * 2), new Rectangle(64, 0, 64, 64), Color.White);
            spriteBatch.Draw(myTexture, new Vector2(64 * 5, 64 * 3), new Rectangle(64, 0, 64, 64), Color.White);
            spriteBatch.Draw(myTexture, new Vector2(64 * 5, 64 * 4), new Rectangle(64, 0, 64, 64), Color.White);
            spriteBatch.Draw(myTexture, new Vector2(64 * 4, 64 * 4), new Rectangle(64, 0, 64, 64), Color.White);
            //Medium Tree
            spriteBatch.Draw(myTexture, new Vector2(64 * 2, 64 * 5), new Rectangle(0, 64 * 3, 64 * 2, 64 * 2), Color.White);
            //Stump
            spriteBatch.Draw(myTexture, new Vector2(64 * 6, 64), new Rectangle(0, 0, 64, 64), Color.White);
            spriteBatch.Draw(myTexture, new Vector2(64 * 9.5f, 64 * 4.3f), new Rectangle(0, 0, 64, 64), Color.White);
            //Small Tree
            spriteBatch.Draw(myTexture, new Vector2(64 * 6.5f, 64 * 4.5f), new Rectangle(64 * 2, 0, 64, 64), Color.White);
            spriteBatch.Draw(myTexture, new Vector2(64 * 8, 64 * 2.5f), new Rectangle(64 * 2, 0, 64, 64), Color.White);
            //Banana Tree
            spriteBatch.Draw(myTexture, new Vector2(64 * 9.7f, 64 * 1.5f), new Rectangle(64 * 2, 64 * 4, 64 * 2, 64 * 2), Color.White);
            //signpost
            spriteBatch.Draw(myTexture, new Vector2(64 * 8, 64 * 5.5f), new Rectangle(0, 64, 64, 64), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
