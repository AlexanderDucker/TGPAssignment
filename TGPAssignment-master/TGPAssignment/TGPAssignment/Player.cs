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
		private Vector2				velocity;
		private float				gravity;
		private bool				hasJumped;
		public bool Alive { get{return alive;} set{alive = value;} }

		
		public Player ()
		{
			alive			= true;
			textureInfo 	= new TextureInfo("Application/textures/sprite-Player-Idle.png");
			sprite 			= new SpriteUV();
			sprite			= new SpriteUV(textureInfo);
			sprite.Position = new Vector2(-14.0f, -7.0f);
			//yVelocity		= 0.92f;
			gravity			= 0.2f;
			hasJumped		= false;
		}
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update()
		{
			var gamePadData = GamePad.GetData(0);
			
			sprite.Position += velocity;
			
			if((gamePadData.Buttons & GamePadButtons.Right) != 0)
	        {
	        	velocity.X = 0.1f; 
	        }
			
			else if((gamePadData.Buttons & GamePadButtons.Left) != 0)
	        {
	        	velocity.X = -0.1f;
	        }
			
			else velocity.X = 0.0f;
			
			if((gamePadData.Buttons & GamePadButtons.Cross) != 0 && !hasJumped)
			{
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y + 1.0f);
				velocity.Y = +0.5f;
				hasJumped = true;
			}
			
			if(hasJumped)
			{
				float i = 1;
				velocity.Y -= 0.05f * i;
			}
			
			if(!hasJumped)
			{
				velocity.Y = 0.0f;
			}
		}
	}
}

