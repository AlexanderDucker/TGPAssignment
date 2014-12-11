using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;
using Sce.PlayStation.Core.Input;


namespace TGPAssignment
{
	public class Player
	{
		public			 SpriteUV 	sprite;
		private static TextureInfo	textureInfo;
		private static bool 		alive;
		private float				yVelocity;
		private float				gravity;
		private bool				isJumping;
		private float				yDestination;
		public bool Alive { get{return alive;} set{alive = value;} }

		
		public Player ()
		{
			alive			= true;
			textureInfo 	= new TextureInfo("Application/textures/sprite-Player-Idle.png");
			sprite 			= new SpriteUV();
			sprite			= new SpriteUV(textureInfo);
			sprite.Position = new Vector2(-14.0f, -8.0f);
			yVelocity		= 0.92f;
			gravity			= 0.2f;
			isJumping		= false;
		}
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update()
		{
			var gamePadData = GamePad.GetData(0);
			if((gamePadData.Buttons & GamePadButtons.Right) != 0)
	        {
	        	sprite.Position = new Vector2(sprite.Position.X + 0.1f, sprite.Position.Y);  
	        }
			
			if((gamePadData.Buttons & GamePadButtons.Left) != 0)
	        {
	        	sprite.Position = new Vector2(sprite.Position.X - 0.1f, sprite.Position.Y);  
	        }
			
			if((gamePadData.Buttons & GamePadButtons.Cross) != 0)
			{
				if(!isJumping)
				{
					isJumping = true;
					yDestination = sprite.Position.Y + 5.0f;
					while(yDestination > sprite.Position.Y)
					{	
						sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y * yVelocity);
						isJumping = false;
					}
				}						
			}
		}
	}
}

