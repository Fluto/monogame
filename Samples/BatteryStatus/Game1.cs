using System;
using XnaTouch;
using XnaTouch.Framework;
using XnaTouch.Framework.Graphics;
using XnaTouch.Samples;
using XnaTouch.Samples.BatteryStatus;

namespace XnaTouch.Samples.BatteryStatus
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : XnaTouch.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;		
		SpriteFont font;

		public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
			
			graphics.IsFullScreen = true;		
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
				
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

			font = Content.Load<SpriteFont>("SpriteFont1");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
		protected override void UnLoadContent ()
		{
			// TODO: Unload any non ContentManager content here
			base.UnLoadContent ();
		}

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here							
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
           	graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
			
			spriteBatch.Begin();
	
			spriteBatch.DrawString(font,"[Battery Status]\n" + PowerStatus.BatteryChargeStatus,new Vector2(10,100),Color.Black);
			
			spriteBatch.DrawString(font,"[PowerLine Status]\n" + PowerStatus.PowerLineStatus,new Vector2(10,200),Color.Black);
			
			spriteBatch.DrawString(font,"Charge: " + PowerStatus.BatteryLifePercent+"%",new Vector2(10,300),Color.Black);
		
			spriteBatch.End();
			
            base.Draw(gameTime);
        }
    }
}
